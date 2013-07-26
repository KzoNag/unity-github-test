using UnityEngine;
using System.Collections;

public class ScriptableObjectTest : ScriptableObject
{
	public int 		m_int;
	public float 	m_float;
	public string	m_string;
	
	void OnEnable()
	{
		m_int = 0;
		m_float = 0.0f;
		m_string = "test";
	}
}
