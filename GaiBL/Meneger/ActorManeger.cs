using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaiBL.Meneger
{
    public class ActorManeger
    {
        GaiEntities entities = new GaiEntities();

        public List<Actor> Actors
        {
            get
            {
                try
                {
                    return entities.Actor.ToList();
                }
                catch
                {
                    throw new Exception("Eror DB");
                }
            }
        }

        public Actor GetActor(int id)
        {
            try
            {
                return entities.Actor.Find(id);
            }
            catch
            {
                throw new Exception("Eror DB");
            }
        }

        public Actor GetActor (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("message", nameof(name));
            }
            try
            {
                return entities.Actor.Where(x => x.Name == name).FirstOrDefault();
            }
            catch
            {
                throw new Exception("Eror DB");
            }

        }

        public void SetActor(Actor actor)
        {
            try
            {
                entities.Actor.Add(actor);
                entities.SaveChanges();
            }
            catch
            {
                throw new Exception("error  BD");
            }
        }
    }
}
