using Profile;
using Tool;
using UnityEngine;

namespace Features.Fight
{
    internal class ExitToMainMenuController : BaseController
    {
        private readonly ResourcePath _resourcePath = new ResourcePath("Prefabs/UI/ExitToMainMenuView");

        private readonly ExitToMainMenuView _view;
        private readonly ProfilePlayer _profilePlayer;


        public ExitToMainMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(MainMenu);
        }


        private ExitToMainMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resourcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi, false);
            AddGameObject(objectView);

            return objectView.GetComponent<ExitToMainMenuView>();
        }

        private void MainMenu()
        {
            _profilePlayer.CurrentState.Value = GameState.Start;
            Debug.Log("123");
        }
    }
}
