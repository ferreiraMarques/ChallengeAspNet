using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorialAsp.Data;
using tutorialAsp.Models;

namespace tutorialAsp.Services
{
    public class JokeServiceImpl: IJokeService
    {
        private readonly ApplicationDbContext _context;

        public JokeServiceImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Joke> getAll()
        {
            return _context.Joke.ToList();
        }

        public Joke getById(int? id)
        {
            return _context.Joke.Find(id);
        }

        public void save(Joke joke)
        {
            try
            {
                _context.Add(joke);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Joke edit(Joke joke)
        {
            try
            {
                _context.Update(joke);
                _context.SaveChanges();
                return getById(joke.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void delete(int? id)
        {
            try
            {
                Joke joke = getById(id);
                _context.Joke.Remove(joke);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public bool JokeExists(int id)
        {
            return _context.Joke.Any(e => e.Id == id);
        }

        public IEnumerable<Joke> searchByTerm(String term)
        {
            return _context.Joke.Where(j => j.Questions.Contains(term)).ToList();

        }

    }
}
