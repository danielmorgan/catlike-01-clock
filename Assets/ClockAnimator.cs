using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {

	private const float
		hoursToDeg = 360f / 12f,
		minutesToDeg = 360f / 60f,
		secondsToDeg = 360f / 60f;

	public Transform hours, minutes, seconds;

	public bool analog;

	private void Update () {
		if (analog) {
			TimeSpan timespan = DateTime.Now.TimeOfDay;

			hours.localRotation   = Quaternion.Euler(0f, 0f, (float) timespan.TotalHours * -hoursToDeg);
			minutes.localRotation = Quaternion.Euler(0f, 0f, (float) timespan.TotalMinutes * -minutesToDeg);
			seconds.localRotation = Quaternion.Euler(0f, 0f, (float) timespan.TotalSeconds * -secondsToDeg);
		}
		else {
			DateTime time = DateTime.Now;

			hours.localRotation   = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDeg);
			minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDeg);
			seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDeg);
		}
	}
}