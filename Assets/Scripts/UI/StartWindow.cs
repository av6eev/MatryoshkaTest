using Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI {
	public class StartWindow : MonoBehaviour 
	{
		public TopUI TopUI;
		public TextMeshProUGUI TotalOrdersCountText;
		public Button StartButton;
		public Button ExitButton;
		
		private void Start() {
			GameplayController .Instance.TotalOrdersServedChanged += OnOrdersChanged;
			StartButton.onClick.AddListener(HandleStart);
			ExitButton.onClick.AddListener(HandleExit);
			
			OnOrdersChanged();
			ChangeViewState(false);
		}

		private void OnDestroy() {
			if ( GameplayController.Instance ) {
				GameplayController.Instance.TotalOrdersServedChanged -= OnOrdersChanged;
			}
			
			StartButton.onClick.RemoveListener(HandleStart);
			ExitButton.onClick.RemoveListener(HandleExit);
		}

		private void HandleExit() {
			GameplayController.Instance.CloseGame();
		}

		private void HandleStart() {
			ChangeViewState(true);
			gameObject.SetActive(false);
		}

		private void OnOrdersChanged() {
			var gc = GameplayController.Instance;
			TotalOrdersCountText.text = $"{gc.OrdersTarget}";
		}

		private void ChangeViewState(bool state)
		{
			TopUI.gameObject.SetActive(state);
			Time.timeScale = state ? 1f : 0f;
		}
	}
}