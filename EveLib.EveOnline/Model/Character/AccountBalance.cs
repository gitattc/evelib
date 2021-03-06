﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Character {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class AccountBalance {
        [XmlElement("rowset")]
        public RowCollection<AccountBalanceRow> Accounts { get; set; }
    }

    [Serializable]
    [XmlRoot("row")]
    public class AccountBalanceRow {
        [XmlAttribute("accountID")]
        public long AccountId { get; set; }

        [XmlAttribute("accountKey")]
        public int AccountKey { get; set; }

        [XmlAttribute("balance")]
        public decimal Balance { get; set; }
    }
}