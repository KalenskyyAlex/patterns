// перш за все модель це класичний суб'єкт з Observer-патерну. Він може додавати спостерігачів та сповіщувати їх
namespace Mixer
{
    interface IModel : IModelState // не забуваємо про IModelState який виконує базові завдання Model
    {
        // нам треба окремо оповіщати дві групи спостерігачів - IBeatObsevers i IBPMObservers
        void addObserver(IBeatObserver beatObserver);
        void removeObserver(IBeatObserver beatObserver);
        void notifyBeatObservers();

        
        void addObserver(IBPMObserver BPMObserver);
        void removeObserver(IBPMObserver BPMObserver);
        void notifyBPMObservers();
    }
}