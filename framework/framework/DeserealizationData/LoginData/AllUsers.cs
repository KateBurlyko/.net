﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace framework.DeserealizationData.LoginData
{
    [Serializable]
    public class AllUsers
    {

        [XmlElement("user")]
        public List<User> Users { get; set; }

        
    }
}
