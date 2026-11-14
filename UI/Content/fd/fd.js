/* =====================================================================
   Foodirect V5 — site runtime (vanilla JS, jQuery optional)
   Public API on window.FD
   ===================================================================== */
(function (w, d) {
    "use strict";

    var FD = w.FD = w.FD || {};

    function $(sel, root) { return (root || d).querySelector(sel); }
    function $$(sel, root) { return Array.prototype.slice.call((root || d).querySelectorAll(sel)); }
    function onReady(fn) { if (d.readyState !== "loading") fn(); else d.addEventListener("DOMContentLoaded", fn); }
    function esc(s) { return String(s == null ? "" : s).replace(/[&<>"']/g, function (c) { return { "&": "&amp;", "<": "&lt;", ">": "&gt;", '"': "&quot;", "'": "&#39;" }[c]; }); }
    FD.esc = esc;

    /* ---------------- Header: sticky shadow, mobile nav, menus ------- */
    function initHeader() {
        var header = $(".site-header");
        if (!header) return;
        var onScroll = function () { header.classList.toggle("is-scrolled", w.scrollY > 4); };
        w.addEventListener("scroll", onScroll, { passive: true }); onScroll();

        var toggle = $(".nav-toggle", header);
        if (toggle) toggle.addEventListener("click", function () {
            var open = header.classList.toggle("nav-open");
            toggle.setAttribute("aria-expanded", open);
            toggle.innerHTML = open ? '<i class="fa-solid fa-xmark"></i>' : '<i class="fa-solid fa-bars"></i>';
        });
        var st = $(".search-toggle", header);
        if (st) st.addEventListener("click", function () {
            header.classList.toggle("search-open");
            var inp = $(".header-search input", header); if (inp) inp.focus();
        });

        // <details> menus: close others + close on outside click / Escape
        var menus = $$(".nav-menu");
        menus.forEach(function (m) {
            m.addEventListener("toggle", function () { if (m.open) menus.forEach(function (o) { if (o !== m) o.open = false; }); });
        });
        d.addEventListener("click", function (e) { menus.forEach(function (m) { if (!m.contains(e.target)) m.open = false; }); });
        d.addEventListener("keydown", function (e) { if (e.key === "Escape") menus.forEach(function (m) { m.open = false; }); });
    }

    /* ---------------- Flash messages ---------------------------------- */
    function initAlerts() {
        d.addEventListener("click", function (e) {
            var b = e.target.closest(".alert-close");
            if (b) { var a = b.closest(".alert"); if (a) a.remove(); }
        });
    }

    /* ---------------- Confirm links/buttons (data-confirm) ----------- */
    function initConfirm() {
        d.addEventListener("click", function (e) {
            var el = e.target.closest("[data-confirm]");
            if (el && !w.confirm(el.getAttribute("data-confirm"))) { e.preventDefault(); e.stopImmediatePropagation(); }
        }, true);
    }

    /* ---------------- Dialog (native <dialog>) ------------------------ */
    var dlg;
    function ensureDialog() {
        if (dlg) return dlg;
        dlg = d.createElement("dialog");
        dlg.className = "fd-dialog";
        dlg.innerHTML = '<div class="fd-dialog-head"><h2></h2><button type="button" class="icon-action" data-close aria-label="Close"><i class="fa-solid fa-xmark"></i></button></div><div class="fd-dialog-body"></div>';
        d.body.appendChild(dlg);
        dlg.addEventListener("click", function (e) {
            if (e.target === dlg || e.target.closest("[data-close]")) dlg.close();
        });
        return dlg;
    }
    /**
     * FD.dialog.open({ title, url, html, width })
     * Loads `url` via fetch (scripts in the response are executed) or shows `html`.
     */
    FD.dialog = {
        open: function (opts) {
            var dl = ensureDialog();
            var body = $(".fd-dialog-body", dl);
            $(".fd-dialog-head h2", dl).textContent = opts.title || "";
            dl.style.width = opts.width ? "min(" + opts.width + "px, calc(100vw - 32px))" : "";
            if (opts.url) {
                body.className = "fd-dialog-body is-loading";
                body.innerHTML = '<span><i class="fa-solid fa-circle-notch spin"></i>&nbsp; Loading…</span>';
                fetch(opts.url, { credentials: "same-origin", headers: { "X-Requested-With": "XMLHttpRequest" } })
                    .then(function (r) { if (!r.ok) throw new Error(r.status); return r.text(); })
                    .then(function (html) { body.className = "fd-dialog-body"; FD.dialog.setContent(html); })
                    .catch(function () { body.className = "fd-dialog-body"; body.innerHTML = '<div class="alert alert-err"><i class="fa-solid fa-triangle-exclamation"></i><div>Sorry, that could not be loaded.</div></div>'; });
            } else {
                body.className = "fd-dialog-body";
                FD.dialog.setContent(opts.html || "");
            }
            if (!dl.open) dl.showModal();
            return dl;
        },
        setContent: function (html) {
            var body = $(".fd-dialog-body", ensureDialog());
            body.innerHTML = html;
            // run inline scripts from fetched partials
            $$("script", body).forEach(function (old) {
                var s = d.createElement("script");
                if (old.src) s.src = old.src; else s.textContent = old.textContent;
                old.parentNode.replaceChild(s, old);
            });
        },
        close: function () { if (dlg && dlg.open) dlg.close(); }
    };

    /** Product details popup used across catalog, specials and order pages. */
    FD.showProduct = function (productCode, e) {
        if (e && e.preventDefault) e.preventDefault();
        var tmp = d.createElement("textarea"); tmp.innerHTML = productCode; productCode = tmp.value; // html-decode
        FD.dialog.open({ title: "Product details", url: "/Product/Product?productCode=" + encodeURIComponent(productCode) });
        return false;
    };

    /* ---------------- Toasts ------------------------------------------ */
    FD.toast = function (msg, type) {
        var host = $(".fd-toasts");
        if (!host) { host = d.createElement("div"); host.className = "fd-toasts"; host.setAttribute("aria-live", "polite"); d.body.appendChild(host); }
        var t = d.createElement("div");
        t.className = "fd-toast" + (type === "err" ? " is-err" : "");
        t.innerHTML = '<i class="fa-solid ' + (type === "err" ? "fa-circle-exclamation" : "fa-circle-check") + '"></i><span></span>';
        t.lastChild.textContent = msg;
        host.appendChild(t);
        setTimeout(function () { t.classList.add("is-leaving"); setTimeout(function () { t.remove(); }, 300); }, 3200);
    };

    /* ---------------- Cart badge -------------------------------------- */
    FD.setCartCount = function (n) {
        $$(".cart-count").forEach(function (c) { c.textContent = n; c.classList.remove("bump"); void c.offsetWidth; c.classList.add("bump"); });
    };

    /* ---------------- Commerce actions (delegated) --------------------
       Row markup:  <tr data-line data-code="ABC123">
                       <input class="js-qty"> <select class="js-uom">
                       <button data-add-to-order [data-require-qty]>
                       <button data-fav-toggle>
       Any element:  <a data-product="ABC123">  → product details dialog
    ------------------------------------------------------------------- */
    function postForm(url, data) {
        var body = Object.keys(data).map(function (k) { return encodeURIComponent(k) + "=" + encodeURIComponent(data[k]); }).join("&");
        return fetch(url, {
            method: "POST", credentials: "same-origin",
            headers: { "Content-Type": "application/x-www-form-urlencoded; charset=UTF-8", "X-Requested-With": "XMLHttpRequest" },
            body: body
        }).then(function (r) { if (!r.ok) throw new Error(r.status); return r.json(); });
    }
    FD.postForm = postForm;

    FD.addToOrder = function (btn) {
        var row = btn.closest("[data-line]");
        if (!row) return;
        var code = row.getAttribute("data-code");
        var qtyEl = row.querySelector(".js-qty"), uomEl = row.querySelector(".js-uom");
        var qty = qtyEl ? parseFloat(qtyEl.value) : 1;
        var uom = (uomEl && uomEl.value) || "CS";
        if (btn.hasAttribute("data-require-qty") && (!qty || qty <= 0)) {
            FD.toast("Enter a quantity first.", "err");
            if (qtyEl) qtyEl.focus();
            return;
        }
        if (!qty || isNaN(qty) || qty <= 0) qty = 1;
        btn.disabled = true;
        postForm("/Order/OrderAddItem", { QTY: qty, UOM: uom, ProductCode: code })
            .then(function (data) {
                if (data.RetVal) {
                    FD.setCartCount(data.Count);
                    btn.classList.add("is-on");
                    FD.toast("Added " + qty + " " + uom + " of " + code + " to your order");
                } else { FD.toast("The line could not be added.", "err"); }
            })
            .catch(function () { FD.toast("Error adding item to the order.", "err"); })
            .then(function () { btn.disabled = false; });
    };

    FD.toggleFavorite = function (btn) {
        var row = btn.closest("[data-line]");
        var code = row ? row.getAttribute("data-code") : btn.getAttribute("data-code");
        postForm("/Product/FavoriteToggle", { ProductCode: code })
            .then(function (data) {
                if (!data.RetVal) { FD.toast("The favorite could not be toggled.", "err"); return; }
                var on = data.ToggledState == 1;
                btn.classList.toggle("is-fav", on);
                btn.querySelector("i").className = (on ? "fa-solid" : "fa-regular") + " fa-star";
                FD.toast(on ? "Added to favorites" : "Removed from favorites");
            })
            .catch(function () { FD.toast("Error toggling favorite.", "err"); });
    };

    function initCommerce() {
        d.addEventListener("click", function (e) {
            var t;
            if ((t = e.target.closest("[data-add-to-order]"))) { e.preventDefault(); FD.addToOrder(t); }
            else if ((t = e.target.closest("[data-fav-toggle]"))) { e.preventDefault(); FD.toggleFavorite(t); }
            else if ((t = e.target.closest("[data-product]"))) { e.preventDefault(); FD.showProduct(t.getAttribute("data-product")); }
        });
        // Enter in a qty box adds that line
        d.addEventListener("keydown", function (e) {
            if (e.key !== "Enter" || !e.target.classList || !e.target.classList.contains("js-qty")) return;
            var row = e.target.closest("[data-line]"), b = row && row.querySelector("[data-add-to-order]");
            if (b) { e.preventDefault(); FD.addToOrder(b); }
        });
    }

    /* ---------------- Product lookup (Tom Select)
       Server contract (unchanged):
       POST /Product/GetProductsForDropDown  {"filter":{"logic":"and","filters":[{"field":"Name","value":q,"ignoreCase":true}]}}
       → [{ Name, Value }]
    ------------------------------------------------------------------- */
    FD.productLookup = function (el, opts) {
        opts = opts || {};
        if (!w.TomSelect || !el) return null;
        return new w.TomSelect(el, {
            valueField: "Value",
            labelField: "Name",
            searchField: ["Name", "Value"],
            maxItems: 1,
            maxOptions: 25,
            create: !!opts.allowFreeText,
            createOnBlur: false,
            persist: false,
            loadThrottle: 250,
            openOnFocus: false,
            placeholder: opts.placeholder || el.getAttribute("placeholder") || "Search products…",
            shouldLoad: function (q) { return q.length >= 2; },
            load: function (q, cb) {
                fetch("/Product/GetProductsForDropDown", {
                    method: "POST", credentials: "same-origin",
                    headers: { "Content-Type": "application/json; charset=utf-8", "X-Requested-With": "XMLHttpRequest" },
                    body: JSON.stringify({ filter: { logic: "and", filters: [{ field: "Name", value: q, ignoreCase: true }] } })
                }).then(function (r) { return r.json(); }).then(function (j) { cb(j); }).catch(function () { cb(); });
            },
            render: {
                option: function (it, e) { return '<div>' + e(it.Name) + (it.Value && it.Value !== it.Name ? '<span class="code">#' + e(it.Value) + '</span>' : '') + '</div>'; },
                item: function (it, e) { return '<div>' + e(it.Name) + '</div>'; },
                option_create: function (data, e) { return '<div class="create">Search for <strong>' + e(data.input) + '</strong>…</div>'; },
                no_results: function () { return '<div class="no-results">No matching products</div>'; },
                loading: function () { return '<div class="spinner"><i class="fa-solid fa-circle-notch spin"></i> Searching…</div>'; }
            },
            onItemAdd: function (value) { if (opts.onSelect) opts.onSelect(value, this.options[value]); }
        });
    };

    /** Global header search: pick a product → filtered catalog; free text + Enter → catalog search. */
    function initHeaderSearch() {
        $$("[data-product-search]").forEach(function (el) {
            FD.productLookup(el, {
                allowFreeText: true,
                onSelect: function (value) {
                    w.location = "/product/products?mode=PRODUCT&ProductAutoComplete=" + encodeURIComponent(value);
                }
            });
        });
    }

    /* ---------------- Hero slider ------------------------------------- */
    function initHero() {
        var hero = $(".hero");
        if (!hero) return;
        var slides = $$(".hero-slide", hero), caps = $$(".hero-caption", hero), dots = $$(".hero-dot", hero);
        if (slides.length < 2) return;
        var i = 0, dur = +(hero.getAttribute("data-interval") || 7000), timer;
        hero.style.setProperty("--dur", dur + "ms");
        function go(n) {
            i = (n + slides.length) % slides.length;
            [slides, caps, dots].forEach(function (set) { set.forEach(function (el, k) { el.classList.toggle("is-active", k === i); }); });
            clearTimeout(timer); timer = setTimeout(function () { go(i + 1); }, dur);
        }
        dots.forEach(function (dot, k) { dot.addEventListener("click", function () { go(k); }); });
        d.addEventListener("visibilitychange", function () { if (d.hidden) clearTimeout(timer); else go(i); });
        go(0);
    }

    /* ---------------- Horizontal rails ------------------------------- */
    function initRails() {
        $$("[data-rail-prev],[data-rail-next]").forEach(function (b) {
            b.addEventListener("click", function () {
                var rail = d.getElementById(b.getAttribute("data-rail-prev") || b.getAttribute("data-rail-next"));
                if (!rail) return;
                var dir = b.hasAttribute("data-rail-prev") ? -1 : 1;
                rail.scrollBy({ left: dir * rail.clientWidth * 0.8, behavior: "smooth" });
            });
        });
    }

    /* ---------------- Reveal + parallax ------------------------------ */
    function initMotion() {
        var els = $$(".reveal");
        if ("IntersectionObserver" in w && els.length) {
            var io = new IntersectionObserver(function (entries) {
                entries.forEach(function (en) { if (en.isIntersecting) { en.target.classList.add("is-in"); io.unobserve(en.target); } });
            }, { rootMargin: "0px 0px -8% 0px" });
            els.forEach(function (el, k) { el.style.transitionDelay = ((+el.getAttribute("data-delay") || 0)) + "ms"; io.observe(el); });
        } else { els.forEach(function (el) { el.classList.add("is-in"); }); }

        var bands = $$(".cta-band");
        if (bands.length && !w.matchMedia("(prefers-reduced-motion: reduce)").matches) {
            var tick = function () {
                bands.forEach(function (b) {
                    var r = b.getBoundingClientRect();
                    if (r.bottom > 0 && r.top < w.innerHeight) b.style.setProperty("--parallax", ((r.top - w.innerHeight / 2) * -0.12).toFixed(1) + "px");
                });
            };
            w.addEventListener("scroll", tick, { passive: true }); tick();
        }
    }

    /* ---------------- Business-day guard for date inputs -------------
       <input type="date|datetime-local" data-business-days> rejects Sat/Sun
 */
    FD.isWeekend = function (value) {
        if (!value) return false;
        var dt = new Date(value.length <= 10 ? value + "T00:00" : value);
        var day = dt.getDay();
        return day === 0 || day === 6;
    };
    function initBusinessDays() {
        $$("[data-business-days]").forEach(function (inp) {
            inp.addEventListener("change", function () {
                if (FD.isWeekend(inp.value)) {
                    FD.toast("Please choose a weekday (Monday–Friday).", "err");
                    inp.value = inp.getAttribute("data-last") || "";
                } else {
                    inp.setAttribute("data-last", inp.value);
                }
            });
            inp.setAttribute("data-last", inp.value);
        });
    }

    /* ---------------- Active nav link -------------------------------- */
    function initActiveNav() {
        var p = location.pathname.toLowerCase();
        $$(".main-nav > a").forEach(function (a) {
            var h = (a.getAttribute("href") || "").toLowerCase();
            if (h && h !== "/" && p.indexOf(h) === 0) a.classList.add("is-active");
        });
    }

    /* ---------------- Skins (see fd-skins.css) ----------------------- */
    var SKINS = ["classic", "midnight", "market", "nordic", "deco", "neon"];
    var SKIN_THEME_COLOR = { classic: "#06352b", midnight: "#05090c", market: "#2a1710", nordic: "#0f172a", deco: "#14110c", neon: "#07040d" };
    FD.getSkin = function () { return d.documentElement.getAttribute("data-skin") || "classic"; };
    FD.setSkin = function (name) {
        if (SKINS.indexOf(name) < 0) name = "classic";
        var root = d.documentElement;
        root.classList.add("skin-switching");
        if (name === "classic") root.removeAttribute("data-skin"); else root.setAttribute("data-skin", name);
        // cookie → server renders the right skin on the next request (no flash)
        d.cookie = "fd-skin=" + name + "; path=/; max-age=31536000; SameSite=Lax";
        try { localStorage.setItem("fd-skin", name); } catch (e) { /* storage blocked */ }
        var meta = $('meta[name="theme-color"]'); if (meta) meta.setAttribute("content", SKIN_THEME_COLOR[name]);
        $$(".skin-option").forEach(function (b) { b.setAttribute("aria-checked", b.getAttribute("data-skin-choice") === name ? "true" : "false"); });
        setTimeout(function () { root.classList.remove("skin-switching"); }, 400);
    };
    function initSkins() {
        var menu = $(".skin-menu");
        // keep the option list in sync with whatever the server rendered
        FD.setSkin(FD.getSkin());
        if (!menu) return;
        $$(".skin-option", menu).forEach(function (b) {
            b.addEventListener("click", function () {
                FD.setSkin(b.getAttribute("data-skin-choice"));
                FD.toast && FD.toast("Theme changed to " + b.querySelector("strong").textContent);
                menu.open = false;
            });
        });
        d.addEventListener("click", function (e) { if (!menu.contains(e.target)) menu.open = false; });
        d.addEventListener("keydown", function (e) { if (e.key === "Escape") menu.open = false; });
    }

    onReady(function () {
        initSkins();
        initHeader(); initAlerts(); initConfirm(); initHeaderSearch(); initCommerce();
        initHero(); initRails(); initMotion(); initBusinessDays(); initActiveNav();
    });

    /* ---------------- Legacy helpers (were in Scripts/MyJScript.js) -- */
    if (w.jQuery) {
        w.jQuery.escape_jquerySelector = function (str) { return str ? str.replace(/([ #;?%&,.+*~\\':"!^$[\]()=>|\/@])/g, "\\$1") : str; };
    }
    w.htmlEncode = function (v) { return v ? esc(v) : ""; };
    w.htmlDecode = function (v) { if (!v) return " "; var t = d.createElement("textarea"); t.innerHTML = v; return t.value; };
})(window, document);
