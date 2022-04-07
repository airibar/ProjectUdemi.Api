using Microsoft.EntityFrameworkCore;
using ProjectUdemi.Api.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUdemi.Api.Repositories
{
    public class SqlStudentRepository : IstudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }

        public StudentAdminContext Context { get; }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.ToListAsync();
        }
    }
}
