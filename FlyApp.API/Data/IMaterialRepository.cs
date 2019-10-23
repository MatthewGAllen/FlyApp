using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlyApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlyApp.API.Data
{
    public interface IMaterialRepository
    {
        Task<Material> GetMaterial(int id);
        Task<IEnumerable<Material>> GetMaterials();
    }
}