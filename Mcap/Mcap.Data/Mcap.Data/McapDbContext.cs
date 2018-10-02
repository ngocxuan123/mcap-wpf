using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Mcap.Data
{
    public class McapDbContext
        : DbContext
    {
        public McapDbContext()
            :  base (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\learn\c#\mca-wpf\mcap-wpf\Mcap\Mcap.Data\Mcap.Data\Data\McapV2.mdf;Integrated Security=True")
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
    }
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Doctor
    {
        public long Id { get; set; }
        public string User { get; set; }
    }
}
