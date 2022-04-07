using ProjectUdemi.Api.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectUdemi.Api.Repositories
{
    public interface IstudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
