public class SetDAZMorphFromAverageBoneAngle : SetDAZMorph
{
	public enum axis
	{
		X = 0,
		Y = 1,
		Z = 2,
		NegX = 3,
		NegY = 4,
		NegZ = 5,
	}

	public DAZBone dazBone1;
	public DAZBone dazBone2;
	public float angleLow;
	public float angleHigh;
	public axis angleAxis1;
	public axis angleAxis2;
	public float currentAxisAngle1;
	public float currentAxisAngle2;
	public float _multiplier;
	public bool clampMorphValue;
}
