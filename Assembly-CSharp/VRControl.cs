using UnityEngine;
using UnityEngine.XR;


public class VRControl : MonoBehaviour
{
	[SerializeField]
	private bool _mirror = true;

	[SerializeField]
	private float _renderScale = 1f;

	public bool mirror
	{
		get
		{
			return _mirror;
		}
		set
		{
			if (_mirror != value)
			{
				_mirror = value;
				//XRSettings.set_showDeviceView(_mirror);
			}
		}
	}

	public float renderScale
	{
		get
		{
			return _renderScale;
		}
		set
		{
			if (_renderScale != value)
			{
				_renderScale = value;
				//XRSettings.set_renderScale(_renderScale);
			}
		}
	}

	private void Start()
	{
		//XRSettings.set_showDeviceView(_mirror);
		//XRSettings.set_renderScale(_renderScale);
	}
}
