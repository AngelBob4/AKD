using Zenject;
using Sources.Model;

namespace Sources.ZenjectComponents
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Storage storage = new Storage();

            Container.Bind<Storage>().FromInstance(storage);
        }
    }
}