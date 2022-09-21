using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Features.Fight
{
    internal class ExitToMainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _exitToMainMenuButton;

        public void Init(UnityAction mainMenu) =>
            _exitToMainMenuButton.onClick.AddListener(mainMenu);

        private void OnDestroy() =>
            _exitToMainMenuButton.onClick.RemoveAllListeners();
    }
}
