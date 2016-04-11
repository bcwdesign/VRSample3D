// First Fantasy for Mobile 1.3.5
//
// Author:	Gold Experience Team (http://www.ge-team.com)
// Details:	https://www.assetstore.unity3d.com/en/#!/content/10822
// Support:	geteamdev@gmail.com
//
// Please direct any bugs/comments/suggestions to support e-mail.

#region Namespaces

using UnityEngine;
using System.Collections;

#endregion // Namespaces

// ######################################################################
// GE_FF_Controller class.
// Responds to load scene buttons.
// ######################################################################

public class GE_FF_Controller : MonoBehaviour
{

	// ########################################
	// MonoBehaviour Functions
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.html
	// ########################################

	#region MonoBehaviour

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html
	void Start()
	{
	}

	// Update is called every frame, if the MonoBehaviour is enabled.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
	void Update()
	{
	}

	#endregion // MonoBehaviour

	// ########################################
	// Load scene functions
	// ########################################

	#region Load scene functions

	public void OnButtonLoad01()
	{
		Application.LoadLevel("FF Demo 01 Forest (960x600px)");
	}

	public void OnButtonLoad02()
	{
		Application.LoadLevel("FF Demo 02 Grassland (960x600px)");
	}

	public void OnButtonLoad03()
	{
		Application.LoadLevel("FF Demo 03 Ruin (960x600px)");
	}

	public void OnButtonLoad04()
	{
		Application.LoadLevel("FF Demo 04 Wasteland (960x600px)");
	}

	public void OnButtonLoad05()
	{
		Application.LoadLevel("FF Demo 05 Lagoon (960x600px)");
	}

	public void OnButtonLoad06()
	{
		Application.LoadLevel("FF Demo 06 Cave (960x600px)");
	}

	public void OnButtonLoad07()
	{
		Application.LoadLevel("FF Demo 07 Crater (960x600px)");
	}

	public void OnButtonLoad08()
	{
		Application.LoadLevel("FF Demo 08 Particle Test (960x600px)");
	}

	public void OnButtonLoad09()
	{
		Application.LoadLevel("FF Demo 09 Arctic (960x600px)");
	}

	#endregion // Load scene functions

}
