using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EFAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
/*
 Ekle, Sil, G�ncelle, Listele ve Id'ye G�re Getir
//��inde A harfi ge�meyen kullan�c�lar� listele
 */