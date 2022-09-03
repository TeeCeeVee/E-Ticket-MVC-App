using eTicketApp.Models;

namespace eTicketApp.Data.Services
{
    //define methods only
    //interfaces are just contracts
    public interface IActorsService
    {
        //get all actors from the database

        IEnumerable<Actor> GetAll();
        Actor GetById(int id); // method to return a single actor

        void Add(Actor actor); // add actor to the database - no return

        Actor Update(int id, Actor newActor); //update actor

        void Delete(int id); // delete actor







    }
}
