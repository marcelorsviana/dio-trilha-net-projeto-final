using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemorizarPalavraApi.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MemorizarPalavraApi.Context
{
    public class PalavraContext : DbContext
    {
        public PalavraContext(DbContextOptions<PalavraContext> options) : base(options)
        {

        }

        public DbSet<Palavra> Palavras { get; set; }
    }
}