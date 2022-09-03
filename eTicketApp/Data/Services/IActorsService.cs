using eTicketApp.Models;

namespace eTicketApp.Data.Services
{
    //define methods only
    //interfaces are just contracts
    public interface IActorsService
    {
        //method signatures -- contracts

        // use Task<> to implement async await in actors controller
        Task<IEnumerable<Actor>>GetAll(); // method to get all actors from the database
        Actor GetById(int id); // method to return a single actor to the user

        void Add(Actor actor); // add actor to the database - no return

        // int id checks if the id exists before update Actor
        Actor Update(int id, Actor newActor); // method to return the updated actor to the user

        void Delete(int id); // delete actor







    }
}
