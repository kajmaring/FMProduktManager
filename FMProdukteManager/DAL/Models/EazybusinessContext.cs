using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Protocols;

#nullable disable

namespace DAL.Models
{
    public partial class EazybusinessContext : DbContext
    {
        public EazybusinessContext()
        {
        }

        public EazybusinessContext(DbContextOptions<EazybusinessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artikel> TArtikel { get; set; }
        public virtual DbSet<ArtikelBeschreibung> TArtikelBeschreibungen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Artikel>(entity =>
            {
                entity.HasKey(e => e.KArtikel);

                entity.ToTable("tArtikel");

                entity.HasIndex(e => e.CAsin, "IX_tArtikel_cASIN");

                entity.HasIndex(e => new { e.CAktiv, e.CLagerAktiv, e.CLagerVariation, e.NIstVater, e.KStueckliste }, "IX_tArtikel_cAktiv_cLagerAktiv_cLagerVariation_nIstVater_kStueckliste");

                entity.HasIndex(e => e.CBarcode, "IX_tArtikel_cBarcode");

                entity.HasIndex(e => e.CGefahrnr, "IX_tArtikel_cGefahrnr");

                entity.HasIndex(e => e.CHan, "IX_tArtikel_cHAN");

                entity.HasIndex(e => e.CIsbn, "IX_tArtikel_cISBN");

                entity.HasIndex(e => e.CJfsku, "IX_tArtikel_cJfsku");

                entity.HasIndex(e => e.CPreisliste, "IX_tArtikel_cPreisliste");

                entity.HasIndex(e => e.CSerie, "IX_tArtikel_cSerie");

                entity.HasIndex(e => e.CSuchbegriffe, "IX_tArtikel_cSuchbegriffe");

                entity.HasIndex(e => e.CUnnummer, "IX_tArtikel_cUNNummer");

                entity.HasIndex(e => e.FEknetto, "IX_tArtikel_fEKNetto");

                entity.HasIndex(e => e.KEigenschaftKombi, "IX_tArtikel_kEigenschaftKombi");

                entity.HasIndex(e => e.KHersteller, "IX_tArtikel_kHersteller");

                entity.HasIndex(e => e.KStueckliste, "IX_tArtikel_kStueckliste_cTeilbar");

                entity.HasIndex(e => new { e.KVaterArtikel, e.CAktiv, e.NIstMindestbestand }, "IX_tArtikel_kVaterArtikel_cAktiv_nIstMindestbestand");

                entity.HasIndex(e => new { e.KVaterArtikel, e.NIstVater }, "IX_tArtikel_kVaterArtikel_nIstVater");

                entity.HasIndex(e => e.KWarengruppe, "IX_tArtikel_kWarengruppe");

                entity.HasIndex(e => e.NSort, "IX_tArtikel_nSort");

                entity.HasIndex(e => new { e.CLagerAktiv, e.NIstVater, e.KStueckliste, e.CLagerVariation }, "IX_tartikel_cLagerAktiv_nIstVater_kStueckliste_cLagerVariation");

                entity.HasIndex(e => e.CArtNr, "UQ_tArtikel_cArtNr")
                    .IsUnique();

                entity.Property(e => e.KArtikel).HasColumnName("kArtikel");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("bRowversion");

                entity.Property(e => e.CAktiv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cAktiv")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CAmazonFnsku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cAmazonFNSKU");

                entity.Property(e => e.CAnmerkung)
                    .IsUnicode(false)
                    .HasColumnName("cAnmerkung");

                entity.Property(e => e.CArtNr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cArtNr");

                entity.Property(e => e.CAsin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cASIN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CBarcode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cBarcode");

                entity.Property(e => e.CDelInet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cDelInet")
                    .IsFixedLength(true);

                entity.Property(e => e.CEpid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cEPID");

                entity.Property(e => e.CErloeskonto)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("cErloeskonto");

                entity.Property(e => e.CGefahrnr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cGefahrnr")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CHan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cHAN");

                entity.Property(e => e.CHerkunftsland)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("cHerkunftsland");

                entity.Property(e => e.CInet)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cInet")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CIsbn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cISBN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CJfsku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cJfsku");

                entity.Property(e => e.CLagerAktiv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cLagerAktiv")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CLagerArtikel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cLagerArtikel")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CLagerKleinerNull)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cLagerKleinerNull")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CLagerVariation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cLagerVariation")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CNeu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cNeu")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CPreisliste)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cPreisliste")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CSerie)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cSerie");

                entity.Property(e => e.CSuchbegriffe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cSuchbegriffe");

                entity.Property(e => e.CTaric)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cTaric");

                entity.Property(e => e.CTeilbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cTeilbar")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CTopArtikel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("cTopArtikel")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CUnnummer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cUNNummer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CUpc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cUPC");

                entity.Property(e => e.DErscheinungsdatum)
                    .HasColumnType("datetime")
                    .HasColumnName("dErscheinungsdatum");

                entity.Property(e => e.DErstelldatum)
                    .HasColumnType("datetime")
                    .HasColumnName("dErstelldatum");

                entity.Property(e => e.DLetzterEk)
                    .HasColumnType("datetime")
                    .HasColumnName("dLetzterEK");

                entity.Property(e => e.DMod)
                    .HasColumnType("datetime")
                    .HasColumnName("dMod");

                entity.Property(e => e.DNeuImSortiment)
                    .HasColumnType("datetime")
                    .HasColumnName("dNeuImSortiment");

                entity.Property(e => e.DZulaufVerfuegbarAm)
                    .HasColumnType("datetime")
                    .HasColumnName("dZulaufVerfuegbarAm");

                entity.Property(e => e.FAbnahmeintervall)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fAbnahmeintervall");

                entity.Property(e => e.FAmazonVk)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fAmazonVK");

                entity.Property(e => e.FArtGewicht)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fArtGewicht");

                entity.Property(e => e.FBreite)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fBreite");

                entity.Property(e => e.FEbayPreis)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fEbayPreis");

                entity.Property(e => e.FEknetto)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fEKNetto");

                entity.Property(e => e.FGewicht)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fGewicht");

                entity.Property(e => e.FGrundpreisMenge)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fGrundpreisMenge");

                entity.Property(e => e.FHoehe)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fHoehe");

                entity.Property(e => e.FLaenge)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fLaenge");

                entity.Property(e => e.FLetzterEk)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fLetzterEK");

                entity.Property(e => e.FMassMenge)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fMassMenge");

                entity.Property(e => e.FPackeinheit)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fPackeinheit");

                entity.Property(e => e.FUvp)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fUVP");

                entity.Property(e => e.FVknetto)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fVKNetto");

                entity.Property(e => e.FVpewert)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("fVPEWert");

                entity.Property(e => e.KBenutzerLetzteAenderung).HasColumnName("kBenutzerLetzteAenderung");

                entity.Property(e => e.KEigenschaftKombi).HasColumnName("kEigenschaftKombi");

                entity.Property(e => e.KGrundPreisEinheit).HasColumnName("kGrundPreisEinheit");

                entity.Property(e => e.KHersteller).HasColumnName("kHersteller");

                entity.Property(e => e.KLieferStatus).HasColumnName("kLieferStatus");

                entity.Property(e => e.KMassEinheit).HasColumnName("kMassEinheit");

                entity.Property(e => e.KSteuerklasse).HasColumnName("kSteuerklasse");

                entity.Property(e => e.KStueckliste).HasColumnName("kStueckliste");

                entity.Property(e => e.KVaterArtikel).HasColumnName("kVaterArtikel");

                entity.Property(e => e.KVerkaufsEinheit).HasColumnName("kVerkaufsEinheit");

                entity.Property(e => e.KVersandklasse).HasColumnName("kVersandklasse");

                entity.Property(e => e.KVpeeinheit).HasColumnName("kVPEEinheit");

                entity.Property(e => e.KWarengruppe).HasColumnName("kWarengruppe");

                entity.Property(e => e.KZustand)
                    .HasColumnName("kZustand")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NAutomatischeLiefertageberechnung)
                    .HasColumnName("nAutomatischeLiefertageberechnung")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NBearbeitungszeit).HasColumnName("nBearbeitungszeit");

                entity.Property(e => e.NCharge).HasColumnName("nCharge");

                entity.Property(e => e.NDelete)
                    .HasColumnName("nDelete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NEbayAbgleich).HasColumnName("nEbayAbgleich");

                entity.Property(e => e.NIstMindestbestand).HasColumnName("nIstMindestbestand");

                entity.Property(e => e.NIstVater).HasColumnName("nIstVater");

                entity.Property(e => e.NLagerbestand)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("nLagerbestand");

                entity.Property(e => e.NLiefertageWennAusverkauft)
                    .HasColumnName("nLiefertageWennAusverkauft")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMhd).HasColumnName("nMHD");

                entity.Property(e => e.NMidestbestand)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("nMidestbestand");

                entity.Property(e => e.NMindestbestellmaenge)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("nMindestbestellmaenge");

                entity.Property(e => e.NNichtBestellbar).HasColumnName("nNichtBestellbar");

                entity.Property(e => e.NPaketlaufzeitMax).HasColumnName("nPaketlaufzeitMax");

                entity.Property(e => e.NPaketlaufzeitMin).HasColumnName("nPaketlaufzeitMin");

                entity.Property(e => e.NProzentualePreisStaffelAktiv).HasColumnName("nProzentualePreisStaffelAktiv");

                entity.Property(e => e.NPuffer).HasColumnName("nPuffer");

                entity.Property(e => e.NPufferTyp).HasColumnName("nPufferTyp");

                entity.Property(e => e.NSeriennummernVerfolgung).HasColumnName("nSeriennummernVerfolgung");

                entity.Property(e => e.NSort).HasColumnName("nSort");

                entity.Property(e => e.NVpe).HasColumnName("nVPE");

                entity.Property(e => e.NZulaufVerfuegbarMenge)
                    .HasColumnType("decimal(28, 14)")
                    .HasColumnName("nZulaufVerfuegbarMenge");
            });

            modelBuilder.Entity<ArtikelBeschreibung>(entity =>
            {
                entity.HasKey(e => new { e.KArtikel, e.KSprache, e.KPlattform, e.KShop });

                entity.ToTable("tArtikelBeschreibung");

                entity.HasIndex(e => new { e.KArtikel, e.KPlattform, e.KSprache }, "IX_tArtikelBeschreibung_kArtikel_kPlattform_kSprache_INCL");

                entity.HasIndex(e => e.KPlattform, "IX_tArtikelBeschreibung_kPlattform_INCL_kArtikel_kSprache");

                entity.HasIndex(e => new { e.KSprache, e.KPlattform }, "IX_tArtikelBeschreibung_kSprache_kPlattform");

                entity.HasIndex(e => new { e.KArtikel, e.KSprache, e.KPlattform }, "IX_tArtikelbeschreibung_kArtikel_kSprache_kPlattform");

                entity.Property(e => e.KArtikel).HasColumnName("kArtikel");

                entity.Property(e => e.KSprache).HasColumnName("kSprache");

                entity.Property(e => e.KPlattform).HasColumnName("kPlattform");

                entity.Property(e => e.KShop).HasColumnName("kShop");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("bRowversion");

                entity.Property(e => e.CBeschreibung)
                    .IsUnicode(false)
                    .HasColumnName("cBeschreibung");

                entity.Property(e => e.CKurzBeschreibung)
                    .HasMaxLength(4255)
                    .IsUnicode(false)
                    .HasColumnName("cKurzBeschreibung");

                entity.Property(e => e.CMetaDescription)
                    .HasMaxLength(4255)
                    .IsUnicode(false)
                    .HasColumnName("cMetaDescription");

                entity.Property(e => e.CMetaKeywords)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("cMetaKeywords");

                entity.Property(e => e.CName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cName");

                entity.Property(e => e.CTitleTag)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("cTitleTag");

                entity.Property(e => e.CUrlPfad)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cUrlPfad");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
