using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Roman.Domains
{
    public partial class RomanContext : DbContext
    {
        public RomanContext()
        {
        }

        public RomanContext(DbContextOptions<RomanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Projetos> Projetos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; Initial Catalog=SENAI_ROMAN_DESAFIO_SIESG; user id=sa; pwd=132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.ToTable("GRUPO");

                entity.HasIndex(e => e.NomeGrupo)
                    .HasName("UQ__GRUPO__D7A66BE177D89DE0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NomeGrupo)
                    .IsRequired()
                    .HasColumnName("NOME_GRUPO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.ToTable("PROFESSOR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdGrupo).HasColumnName("ID_GRUPO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.NomeProfessor)
                    .IsRequired()
                    .HasColumnName("NOME_PROFESSOR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Professor)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK__PROFESSOR__ID_GR__5070F446");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Professor)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__PROFESSOR__ID_US__4F7CD00D");
            });

            modelBuilder.Entity<Projetos>(entity =>
            {
                entity.ToTable("PROJETOS");

                entity.HasIndex(e => e.NomeProjeto)
                    .HasName("UQ__PROJETOS__59BBE5AF5CC33F22")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

                entity.Property(e => e.NomeProjeto)
                    .IsRequired()
                    .HasColumnName("NOME_PROJETO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Situacao).HasColumnName("SITUACAO");

                entity.Property(e => e.Tema)
                    .IsRequired()
                    .HasColumnName("TEMA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProfessorNavigation)
                    .WithMany(p => p.Projetos)
                    .HasForeignKey(d => d.IdProfessor)
                    .HasConstraintName("FK__PROJETOS__ID_PRO__5441852A");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIO__161CF724900C245D")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasColumnName("TIPO_USUARIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
