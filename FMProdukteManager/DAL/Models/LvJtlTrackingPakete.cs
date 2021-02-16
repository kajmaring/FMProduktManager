﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LvJtlTrackingPakete
    {
        public int KVersand { get; set; }
        public string CTrackingId { get; set; }
        public DateTime? DErstellt { get; set; }
        public byte NVersandStatus { get; set; }
        public DateTime? DregisteredAt { get; set; }
        public string CLieferscheinnummer { get; set; }
        public int KLieferschein { get; set; }
        public string CAuftragsnummer { get; set; }
        public int KBestellung { get; set; }
        public int KKunde { get; set; }
        public int? KZahlungsart { get; set; }
        public string CExterneBestellnummer { get; set; }
        public int KFirma { get; set; }
        public string CRechnungsnummer { get; set; }
        public string CRechnungsadresseTitel { get; set; }
        public string CRechnungsadresseFirma { get; set; }
        public string CRechnungsadresseVorname { get; set; }
        public string CRechnungsadresseNachname { get; set; }
        public string CRechnungsadresseZusatz { get; set; }
        public string CRechnungsadresseStrasse { get; set; }
        public string CRechnungsadressePlz { get; set; }
        public string CRechnungsadresseOrt { get; set; }
        public string CRechnungsadresseLand { get; set; }
        public string CRechnungsadresseMail { get; set; }
        public string CRechnungsadresseTelefon { get; set; }
        public string CRechnungsadresseFax { get; set; }
        public string CLieferadresseTitel { get; set; }
        public string CLieferadresseFirma { get; set; }
        public string CLieferadresseVorname { get; set; }
        public string CLieferadresseNachname { get; set; }
        public string CLieferadresseZusatz { get; set; }
        public string CLieferadresseStrasse { get; set; }
        public string CLieferadressePlz { get; set; }
        public string CLieferadresseOrt { get; set; }
        public string CLieferadresseLand { get; set; }
        public string CLieferadresseBundesland { get; set; }
        public string CLieferadresseMail { get; set; }
        public string CLieferadresseTelefon { get; set; }
        public string CLieferadresseFax { get; set; }
        public string CLieferadresseAdressZusatz { get; set; }
        public string CLieferadresseAnrede { get; set; }
        public string CKundeNr { get; set; }
        public string CKundeTitel { get; set; }
        public string CKundeFirma { get; set; }
        public string CKundeVorname { get; set; }
        public string CKundeNachname { get; set; }
        public string CKundeZusatz { get; set; }
        public string CKundeStrasse { get; set; }
        public string CKundePlz { get; set; }
        public string CKundeOrt { get; set; }
        public string CKundeLand { get; set; }
        public string CKundeMail { get; set; }
        public string CKundeTelefon { get; set; }
        public string CKundeFax { get; set; }
        public byte NTrackingServiceProvider { get; set; }
        public string CVersandart { get; set; }
        public int? KVersandart { get; set; }
        public byte NTrackingStatus { get; set; }
        public string CFirma { get; set; }
        public DateTime? DnextUpdateAttempt { get; set; }
    }
}
