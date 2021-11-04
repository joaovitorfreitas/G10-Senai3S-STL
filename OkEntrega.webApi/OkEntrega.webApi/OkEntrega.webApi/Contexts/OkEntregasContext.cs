using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OkEntrega.webApi.Domains;

#nullable disable

namespace OkEntrega.webApi.Contexts
{
    public partial class OkEntregasContext : DbContext
    {
        public OkEntregasContext()
        {
        }

        public OkEntregasContext(DbContextOptions<OkEntregasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<Linkedin> Linkedins { get; set; }
        public virtual DbSet<Reuniao> Reuniaos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioLead> UsuarioLeads { get; set; }
        public virtual DbSet<WhatsApp> WhatsApps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CYBERNOTE-14\\SQLEXPRESS;initial catalog=OKEntregas; user Id=sa; pwd=Senai@132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.IdEmail)
                    .HasName("PK__Email__E80F8BD4C2B9689D");

                entity.ToTable("Email");

                entity.Property(e => e.Email1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Email");

                entity.HasOne(d => d.IdLeadsNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.IdLeads)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Email__IdLeads__47DBAE45");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__Empresa__5EF4033EF9ACC063");

                entity.ToTable("Empresa");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EmailEmpresa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomeEmpresa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDeTelefone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentoDeMercado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lead>(entity =>
            {
                entity.HasKey(e => e.IdLeads)
                    .HasName("PK__Leads__BD65919400A7F727");

                entity.Property(e => e.Necessidades)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Leads__IdEmpresa__3E52440B");

                entity.HasOne(d => d.IdUsuarioLeadsNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.IdUsuarioLeads)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Leads__IdUsuario__3D5E1FD2");
            });

            modelBuilder.Entity<Linkedin>(entity =>
            {
                entity.HasKey(e => e.IdLinkedin)
                    .HasName("PK__Linkedin__8D7E36B8EC446ECF");

                entity.ToTable("Linkedin");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTelefone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLeadsNavigation)
                    .WithMany(p => p.Linkedins)
                    .HasForeignKey(d => d.IdLeads)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Linkedin__IdLead__4AB81AF0");
            });

            modelBuilder.Entity<Reuniao>(entity =>
            {
                entity.HasKey(e => e.IdReuniao)
                    .HasName("PK__Reuniao__BA758BE3676C7796");

                entity.ToTable("Reuniao");

                entity.Property(e => e.Ata)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ATA");

                entity.Property(e => e.DataInicio).HasColumnType("datetime");

                entity.Property(e => e.DataTermino).HasColumnType("datetime");

                entity.HasOne(d => d.IdLeadsNavigation)
                    .WithMany(p => p.Reuniaos)
                    .HasForeignKey(d => d.IdLeads)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reuniao__IdLeads__4222D4EF");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reuniaos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reuniao__IdUsuar__412EB0B6");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF9795F035D7");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D105345C7E09D1")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioLead>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioLeads)
                    .HasName("PK__UsuarioL__0B3D50E9CB60D119");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusLead)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("statusLead");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WhatsApp>(entity =>
            {
                entity.HasKey(e => e.IdContato)
                    .HasName("PK__WhatsAPP__2AC4F06449FAEE02");

                entity.ToTable("WhatsAPP");

                entity.Property(e => e.NumeroContato)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLeadsNavigation)
                    .WithMany(p => p.WhatsApps)
                    .HasForeignKey(d => d.IdLeads)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WhatsAPP__IdLead__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
