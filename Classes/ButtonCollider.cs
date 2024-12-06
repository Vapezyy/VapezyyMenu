using Photon.Pun;
using UnityEngine;
using static VapeMenu.Menu.Main;

namespace VapeMenu.Classes
{
	public class Button : MonoBehaviour
	{
		public string relatedText;
		
		public void OnTriggerEnter(Collider collider)
		{
			if (Time.time > buttonCooldown && (collider == buttonCollider || collider == lKeyCollider || collider == rKeyCollider) && menu != null)
			{
                buttonCooldown = Time.time + 0.2f;
				MakeButtonSound(relatedText);
				Toggle(relatedText, true);
            }
		}
	}
}