using BreadFinder.API.DAL.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadFinder.API.BLL
{
    public interface IEigenaarDTO
    {
        EigenaarDTO ConvertToEigenaarDTO(Eigenaar eigenaar);
        Eigenaar ConvertToEigenaarENT(EigenaarDTO eigenaarDTO);
    }
}
