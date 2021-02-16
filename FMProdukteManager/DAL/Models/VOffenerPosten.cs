﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class VOffenerPosten
    {
        public int KBestellung { get; set; }
        public string CBestellNr { get; set; }
        public string CExterneBestellNr { get; set; }
        public decimal FWert { get; set; }
        public decimal FZahlung { get; set; }
        public decimal? FWertOffen { get; set; }
        public string CRechnungsNr { get; set; }
        public string CKundenNr { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseName { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseName { get; set; }
        public string CLieferadresseVorname { get; set; }
        public decimal? FSkontoBetrag { get; set; }
        public decimal FMahngebuehr { get; set; }
        public string CItemId { get; set; }
        public string CTransactionId { get; set; }
        public string CEbayBuyerUserId { get; set; }
        public string CLieferscheinNr { get; set; }
        public int? NPaketnummer { get; set; }
        public string CTrackingId { get; set; }
        public string CGutschriftNr { get; set; }
        public string CEbayCheckoutVerwendungszweck { get; set; }
        public DateTime? DErstellt { get; set; }
        public string CWaehrungIso { get; set; }
        public byte? NStorno { get; set; }
        public string CPaymentBestellNr { get; set; }
    }
}
