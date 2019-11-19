using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiBL.Meneger
{
    public  class UserManeger
    {
        GaiEntities Entities = new GaiEntities();

        public List<Users> Users 
        {
            get
            {
                try
                {
                    return Entities.Users.Where(x => x.Show == true).OrderBy(x => x.Name ).ToList();
                }
                catch
                {
                    throw new Exception("Error Db");
                }
            }
           
        }

        public  void SetUser ( ref Users user )
        {
            try
            {
                var us = Entities.Users.Find(user.IdUser);
                var log = Entities.Login.Find(user.IdUser);
                Entities.Entry(us).CurrentValues.SetValues(user);
                Entities.Entry(log).CurrentValues.SetValues(user.Login);
                Entities.SaveChanges();
            }
            catch
            {
                throw new Exception("Error Db");
            }

        }
       
        public  Users GetUser ( int  id)
        {
            try 
            {
                return Entities.Users.Where(x => x.IdUser == id).Last(); 
            }
            catch
            {
                throw new Exception("Error Db");
            }
        }

        public Users GetUser(string name , string surname  )
        {
            try
            {
                return Entities.Users.Where( (x )  => x.Name == name && x.SurName == surname ).Last();
            }
            catch
            {
                throw new Exception("Error Db");
            }
        }

        public Users GetUser( string  login)
        {
            try
            {
                int  id =  Entities.Login.Where(x => x.Login1 == login).Last().IdUser;
                return GetUser(id);
            }
            catch
            {
                throw new Exception("Error Db");
            }
        }

        public  void AddUser ( Users users )
        {
            try
            {
                Entities.Users.Add(users);
                Entities.SaveChanges();
            }
            catch
            {
                throw new Exception("Error Db");
            }
        }


    }
}
