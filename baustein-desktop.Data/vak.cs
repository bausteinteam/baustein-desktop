//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baustein_desktop.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class vak
    {
        public int ID { get; set; }
        public Nullable<int> ind { get; set; }
        public string zuordnung { get; set; }

        [DisplayName("BA Zuscheidung\r\n(Budgetverantwortlicher)")]
        public string bauabschnitt { get; set; }
        public string lfdnr { get; set; }

        [DisplayName("Zuständigkeit Einkauf")]
        public string zuständigkeit_einkauf { get; set; }

        [DisplayName("iTWO-Vertragsnummer")]
        public string itwonr { get; set; }

        [DisplayName("Vergabeeinheit Nummer")]
        public string ve { get; set; }

        [DisplayName("Ansprechpartner / \r\nVerantwortlicher")]
        public string ansprechpartner_verantwortlicher { get; set; }

        [DisplayName("Vergabeeinheit \r\nBezeichnung")]
        public string vergabeeinheit_bezeichnung { get; set; }
        public Nullable<int> leistung_fertig_sr_angefordert_kfm_abschluss { get; set; }

        [DisplayName("Bemerkungen RZ / DB")]
        public string prüfvermerk_anmerkung { get; set; }

        [DisplayName("Grobkostenschätzung")]
        public Nullable<decimal> grobkosten_budget_order_anschlag_auftrag { get; set; }

        [DisplayName("Art des öffentlichen\r\nAuftrags (§ 103 GWB)")]
        public string art_des_öffentlichen_auftrags { get; set; }

        [DisplayName("EU oder national")]
        public string eu_nat { get; set; }

        [DisplayName("Nutzung 20 % - \r\nKontingent")]
        public Nullable<decimal> nutzung_20_prozent_kontingent { get; set; }

        [DisplayName("Vergabeart")]
        public string vergabeart { get; set; }

        [DisplayName("Vergabeverfahren")]
        public string vergabeverfahren { get; set; }

        [DisplayName("beginn lv erstellung leer")]
        public string beginn_lv_erstellung_leer { get; set; }

        public Nullable<int> beginn_lv_erstellung_at { get; set; }
        public string beginn_lv_erstellung_wt { get; set; }

        [DisplayName("Beginn LV Erstellung")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? beginn_lv_erstellung_datum { get; set; }
        public string übergabe_lese_lv_leer { get; set; }
        public Nullable<int> übergabe_lese_lv_at { get; set; }
        public string übergabe_lese_lv_wt { get; set; }
       
        [DisplayName("Übergabe Lese-LV\r\ninkl. Auspreisung")]
        public Nullable<System.DateTime> übergabe_lese_lv_datum { get; set; }
        public string prüfung_lese_lv_durch_ag_bis_leer { get; set; }
        public Nullable<int> prüfung_lese_lv_durch_ag_bis_at { get; set; }
        public string prüfung_lese_lv_durch_ag_bis_wt { get; set; }

        [DisplayName("Prüfung Lese LV\r\ndurch den AG und Überarbeitung\r\ndurch AN bis")]
        public Nullable<System.DateTime> prüfung_lese_lv_durch_ag_bis_datum { get; set; }
        public string vorlage_konzeption_leer { get; set; }
        public Nullable<int> vorlage_konzeption_at { get; set; }
        public string vorlage_konzeption_wt { get; set; }

        [DisplayName("Vorlage Konzeption (Termine,\r\nBudget, Eignungs- und \r\nWertungskriterien)")]
        public Nullable<System.DateTime> vorlage_konzeption_datum { get; set; }
        public string erstellen_azv_leer { get; set; }
        public Nullable<int> erstellen_azv_at { get; set; }
        public string erstellen_azv_wt { get; set; }

        [DisplayName("Erstellen und Mitzeichnung der\r\nAbstimmung zur Vergabe\r\n(AzV)")]
        public Nullable<System.DateTime> erstellen_azv_datum { get; set; }
        public string übergabe_tna_und_vu_leer { get; set; }
        public Nullable<int> übergabe_tna_und_vu_at { get; set; }
        public string übergabe_tna_und_vu_wt { get; set; }

        [DisplayName("Übergabe Entwurf\r\nTeilnahmeantrag (TNA) und\r\nVergabeunterlagen (VU) an\r\nEinkauf")]
        public Nullable<System.DateTime> übergabe_tna_und_vu_datum { get; set; }
        public string prüfung_kfm_und_jur_leer { get; set; }
        public Nullable<int> prüfung_kfm_und_jur_at { get; set; }
        public string prüfung_kfm_und_jur_wt { get; set; }

        [DisplayName("kfm. und jur. Prüfung\r\nTN und VU durch Einkauf")]
        public Nullable<System.DateTime> prüfung_kfm_und_jur_datum { get; set; }
        public string einarbeiten_korrekturen_leer { get; set; }
        public Nullable<int> einarbeiten_korrekturen_at { get; set; }
        public string einarbeiten_korrekturen_wt { get; set; }

        [DisplayName("Einarbeitung Korrekturen in\r\nTN und VU, Übergabe\r\nversandfertiges LV und \r\nAusschreibungsunterlagen\r\nbis")]
        public Nullable<System.DateTime> einarbeiten_korrekturen_datum { get; set; }
        public string mitzeichnung_azv_leer { get; set; }
        public Nullable<int> mitzeichnung_azv_at { get; set; }
        public string mitzeichnung_azv_wt { get; set; }

        [DisplayName("Mitzeichnung AzV \r\ndurch  VRI/ GS.EI-\r\nx/GS.EI*/GS.E*")]
        public Nullable<System.DateTime> mitzeichnung_azv_datum { get; set; }
        public Nullable<int> summe_tage_abstimmungsprozess { get; set; }
        public string absenden_bekanntmachung_leer { get; set; }
        public Nullable<int> absenden_bekanntmachung_at { get; set; }
        public string absenden_bekanntmachung_wt { get; set; }

        [DisplayName("Absenden der \r\nBekanntmachung\r\nDienstags (EU)\r\nbzw. Aufforderung an \r\nzugelassene Bewerber \r\n(VVoT-EU)")]
        public Nullable<System.DateTime> absenden_bekanntmachung_datum { get; set; }
        public string teilnahmeanträge_bewerbungsfrist_leer { get; set; }
        public Nullable<int> teilnahmeanträge_bewerbungsfrist_at { get; set; }
        public string teilnahmeanträge_bewerbungsfrist_wt { get; set; }

        [DisplayName("Teilnahmeanträge und\r\n Öffnung Teilnahmeanträge \r\n(Bewerbungsfrist) bis")]
        public Nullable<System.DateTime> teilnahmeanträge_bewerbungsfrist_datum { get; set; }
        public string bewerberauswahl_teilnahmeanträge_leer { get; set; }
        public Nullable<int> bewerberauswahl_teilnahmeanträge_at { get; set; }
        public string bewerberauswahl_teilnahmeanträge_wt { get; set; }

        [DisplayName("Bewerberauswahl \r\nTeilnahmeanträge und \r\nInformation an nicht \r\nzugelassene Bieter")]
        public Nullable<System.DateTime> bewerberauswahl_teilnahmeanträge_datum { get; set; }
        public string angebotsfrist_leer { get; set; }
        public Nullable<int> angebotsfrist_at { get; set; }
        public string angebotsfrist_wt { get; set; }


        public Nullable<System.DateTime> angebotsfrist_datum { get; set; }
        public string angebotseröffnung_leer { get; set; }
        public Nullable<int> angebotseröffnung_at { get; set; }
        public string angebotseröffnung_wt { get; set; }

        [DisplayName("Angebotsfrist\r\n(EU 31/15 KT)\r\n(nat. >10 KT)\r\n(mit TN 11 KT)")]
        public Nullable<System.DateTime> angebotseröffnung_datum { get; set; }
        public string formale_prüfung_db_leer { get; set; }
        public Nullable<int> formale_prüfung_db_at { get; set; }
        public string formale_prüfung_db_wt { get; set; }

        [DisplayName("Formale, rechn. \r\nKaufm. und \r\ntechn. Prüfung \r\nund Wertung \r\nEinkauf (DB) ")]
        public Nullable<System.DateTime> formale_prüfung_db_datum { get; set; }
        public string aufklärungsgespräche_verhandlung_leer { get; set; }
        public Nullable<int> aufklärungsgespräche_verhandlung_at { get; set; }
        public string aufklärungsgespräche_verhandlung_wt { get; set; }

        [DisplayName("Durchführung techn. \r\nAufklärungsgespräche bzw. \r\nVerhandlung bis")]
        public Nullable<System.DateTime> aufklärungsgespräche_verhandlung_datum { get; set; }
        public string angebotsfrist2_leer { get; set; }
        public Nullable<int> angebotsfrist2_at { get; set; }
        public string angebotsfrist2_wt { get; set; }

        [DisplayName("2. Angebotsfrist\r\n (nur Verhandlungsverfahren \r\nVVoT-EU, VVmöT-EU)")]
        public Nullable<System.DateTime> angebotsfrist2_datum { get; set; }
        public string finale_prüfung_leer { get; set; }
        public Nullable<int> finale_prüfung_at { get; set; }
        public string finale_prüfung_wt { get; set; }

        [DisplayName("Finale Prüfung und \r\nWertung, Erstellung \r\nDokumentation und \r\nVergabevorschlag VV, \r\nVorlage unter-\r\nzeichneter VV")]
        public Nullable<System.DateTime> finale_prüfung_datum { get; set; }
        public string versand_bieterinformation_leer { get; set; }
        public Nullable<int> versand_bieterinformation_at { get; set; }
        public string versand_bieterinformation_wt { get; set; }

        [DisplayName("Versand Bieterinfor-\r\nmation nach \r\n§ 134 GWB")]
        public Nullable<System.DateTime> versand_bieterinformation_datum { get; set; }
        public string wartefrist_leer { get; set; }
        public Nullable<int> wartefrist_at { get; set; }
        public string wartefrist_wt { get; set; }

        [DisplayName("Wartefrist § 134 GWB\r\n(bei EU weiten \r\nVerfahren)")]
        public Nullable<System.DateTime> wartefrist_datum { get; set; }
        public string einholung_unterschriften_leer { get; set; }
        public Nullable<int> einholung_unterschriften_at { get; set; }
        public string einholung_unterschriften_wt { get; set; }

        [DisplayName("Einholung Unter-\r\nschriften Vertrag \r\nund Zuschlags-\r\nerteilung, Bindefrist")]
        public Nullable<System.DateTime> einholung_unterschriften_datum { get; set; }

        [DisplayName("Summe Tage Vergabeprozess")]
        public Nullable<int> summe_tage_vergabeprozess { get; set; }
        public Nullable<int> vorlauf_vorbereitungszeit { get; set; }
        public string leistungsbeginn_gem_gap_leer1 { get; set; }
        public string leistungsbeginn_gem_gap_leer2 { get; set; }
        public string leistungsbeginn_gem_gap_wt { get; set; }

        [DisplayName("Leistungsbeginn\r\ngemäß \r\nGeneralablaufplan")]
        public Nullable<System.DateTime> leistungsbeginn_gem_gap_datum { get; set; }
        public Nullable<bool> update_status { get; set; }
        public Nullable<bool> abstimmung_mit_einkauf { get; set; }
        public string pb { get; set; }

        public Nullable<bool> azv_abstimmung { get; set; }

        [DisplayName("Übergabe der \r\nVertragsunterlagen an\r\nBedarfsträger")]
        public Nullable<System.DateTime> übergabe_vertragsunterlagen { get; set; }
        public string beschaffungswert { get; set; }
        public string prüfvermerk_anmerkung_einkauf { get; set; }
        public string vergabeeinheit_beschreibung { get; set; }
        public string auftragnehmer { get; set; }

        [DisplayName("KKE")]
        public bool? kke { get; set; }

        public decimal? grobkostenschätzung { get; set; }
        public Nullable<bool> sichtbar { get; set; }

        [DisplayName("Bauabschnitt iTWO (ordner2)")]
        public string ordner2 { get; set; }

        [DisplayName("Entscheidung zur Vergabe")]
        public Nullable<bool> ezv_abstimmung { get; set; }

        [DisplayName("Bauabschnitt iTWO (ordner3)")]
        public string ordner3 { get; set; }

        [DisplayName("Beschreibung RZ")]
        public string ve_beschreibung_rz { get; set; }

        [DisplayName("Buchungskreis")]
        public string bkr { get; set; }

        [DisplayName("STP Vertrags-\r\nabschluss")]
        public Nullable<bool> msp_va { get; set; }

        [DisplayName("STP Leistungs-\r\nbeginn")]
        public Nullable<bool> msp_lb { get; set; }
        public string ba_zuscheidung { get; set; }
        public string puffer { get; set; }

        [DisplayName("STP Bekannt-\r\nmachung")]
        public Nullable<bool> msp_bk { get; set; }
    }
}
