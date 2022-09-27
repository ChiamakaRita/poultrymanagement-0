using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poultrymanagement_0.Models;

namespace poultrymanagement_0.Services
{
    public interface IPoultryService
    {
        int AddOne(Bird bird);
        int AddMany(List<Bird> birds);
        List<Bird> GetBirds();
    }
}