/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/4/2023 1:41:49 PM
===============================================================================
*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;

using EntitySpaces.Interfaces;
using EntitySpaces.Core;

namespace BusinessObjects
{
	public partial class V5EmailBlastBO : esV5EmailBlastBO
	{

        private V5EmailBlastAttachmentCollection attachments = null;

        public V5EmailBlastAttachmentCollection Attachments
        {
            get
            {
                if (attachments == null)
                {

                    attachments = new V5EmailBlastAttachmentCollection();
                    var q = new V5EmailBlastAttachmentQuery();
                    q.Where(q.EmailBlastID.Equal(this.EmailBlastID.Value));
                    attachments.Load(q);
                }
                return attachments;
            }
        }

    }
}
