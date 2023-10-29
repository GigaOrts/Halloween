using UnityEngine;
using UnityEngine.UI;

namespace Halloween
{
    public class ExitGame : MonoBehaviour
    {
        [SerializeField] private GameObject _exitGameScreen;
        
        [Space]
        [SerializeField] private Button _buttonYes;
        [SerializeField] private Button _buttonNo;

        private void OnEnable()
        {
            _buttonYes.onClick.AddListener(OnButtonClickYes);
            _buttonNo.onClick.AddListener(OnButtonClickNo);
        }

        private void OnDisable()
        {
            _buttonYes.onClick.RemoveListener(OnButtonClickYes);
            _buttonNo.onClick.RemoveListener(OnButtonClickNo);
        }

        private void OnButtonClickYes() => 
            Application.Quit();

        private void OnButtonClickNo()
        {
            Time.timeScale = 1;
            _exitGameScreen.SetActive(false);
        }
    }
}