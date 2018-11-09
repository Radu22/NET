using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;

namespace BusinessLayer
{
    public class PoiRepository : IRepository<Poi>
    {
        private readonly PoiContext _poiContext;

        public PoiRepository(PoiContext poiContext)
        {
            _poiContext = poiContext;
        }

        public void Create(Poi entity)
        {
            _poiContext.Pois.Add(entity);
            _poiContext.SaveChanges();
        }

        public void Update(Poi entity)
        {
            _poiContext.Set<Poi>().Update(entity);
            _poiContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var poi = GetById(id);
            _poiContext.Pois.Remove(poi);
            _poiContext.SaveChanges();
        }

        public Poi GetById(Guid id)
        {
            return _poiContext.Pois.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Poi> GetAll()
        {
            return _poiContext.Pois.ToList();
        }

        public void Save()
        {
            _poiContext.SaveChanges();
        }
    }
}
