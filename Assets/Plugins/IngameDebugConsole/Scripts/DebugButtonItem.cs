using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DebugButtonItem : MonoBehaviour
{	
	// Cached components
	[SerializeField]
	private Button Button;
	[SerializeField]
	private TextMeshProUGUI ButtonTitle;

	public void Setup (ConsoleButtonInfo debugButtonInfo)
	{
		ButtonTitle.text = debugButtonInfo.buttonTitle;
		Button.onClick.AddListener(() => {
			debugButtonInfo.method.Invoke(null, null);
		});
	}

	public void SetupGroup(string name)
	{
		Button.image.color = Color.blue;
		ButtonTitle.text = name;
		Button.onClick.AddListener(() => {
			DebugLogManager.instance.SetDebugButtonMenuGroup(name);
		});
	}

	public void SetupBackButton()
	{
		Button.image.color = Color.blue;
		ButtonTitle.text = "< Back";
		Button.onClick.AddListener(() => {
			DebugLogManager.instance.SetDebugButtonMenuGroup("root");
		});
	}
}
