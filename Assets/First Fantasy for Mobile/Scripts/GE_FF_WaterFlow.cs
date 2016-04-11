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
// GE_FF_WaterFlow class.
// Changes UV coordinate.
// ######################################################################

public class GE_FF_WaterFlow : MonoBehaviour
{
	// ########################################
	// Variables
	// ########################################

	#region Variables

	public float m_SpeedU = 0.1f;
	public float m_SpeedV = -0.1f;

	#endregion // Variables

	// ########################################
	// MonoBehaviour Functions
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.html
	// ########################################

	#region MonoBehaviour

	// Update is called every frame, if the MonoBehaviour is enabled.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
	void Update()
	{
		float newOffsetU = Time.time * m_SpeedU;
		float newOffsetV = Time.time * m_SpeedV;

		if (this.GetComponent<Renderer>())
		{
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2(newOffsetU, newOffsetV);
		}
	}

	#endregion // MonoBehaviour
}
