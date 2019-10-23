using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlyApp.API.Data
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly DataContext _context;
        public MaterialRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Material> GetMaterial(int id)
        {
            var mat = await _context.Materials.FirstOrDefaultAsync(u => u.Id == id);
            return mat;
        }

        public async Task<IEnumerable<Material>> GetMaterials()
        {
            var mats = await _context.Materials.ToListAsync();

            return mats;
        }
    }
}