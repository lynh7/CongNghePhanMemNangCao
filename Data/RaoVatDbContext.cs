using CNPMNC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Data
{
    public class RaoVatDbContext : DbContext
    {

        public RaoVatDbContext(DbContextOptions<RaoVatDbContext> options) : base(options)
        {

        }
        
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
        
      
       
        public DbSet<CNPMNC.Models.Category> Categories { get; set; }
        public DbSet<CNPMNC.Models.HinhThuc> HinhThucs { get; set; }
        public DbSet<CNPMNC.Models.City> Cities { get; set; }
        public DbSet<CNPMNC.Models.TinhTrang> TinhTrangs { get; set; }
        public DbSet<CNPMNC.Models.TrangThai> TrangThais { get; set; }
        public DbSet<CNPMNC.Models.LoaiTin> LoaiTins { get; set; }
        public DbSet<CNPMNC.Models.TinRaoVat> TinRaoVats { get; set; }



    }
}
