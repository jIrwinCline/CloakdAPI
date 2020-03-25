using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CloakdAppContext : DbContext
    {
        public CloakdAppContext(DbContextOptions<CloakdAppContext> options)
            : base(options)
        {

        }
    }
}
