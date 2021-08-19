using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorialAsp.Models;

namespace tutorialAsp.Services
{
    public interface IJokeService
    {
        public IEnumerable<Joke> getAll();

        public Joke getById(int? id);

        public void save(Joke joke);

        public Joke edit(Joke joke);

        public void delete(int? id);

        public bool JokeExists(int id);

        public IEnumerable<Joke> searchByTerm(String term);
    }
}
