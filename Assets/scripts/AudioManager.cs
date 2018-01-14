using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;

	public static AudioManager instance;

	void Awake() {

		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
			return;
		}
			

		DontDestroyOnLoad (gameObject);

		foreach (Sound sound in sounds) {
			sound.audioSource = gameObject.AddComponent<AudioSource> ();
			sound.audioSource.clip = sound.audioClip;

			sound.audioSource.volume = sound.volume;
			sound.audioSource.pitch = sound.pitch;
			sound.audioSource.loop = sound.loop;
		}
	}

	void Start() {
		Play ("MusicTheme");
	}

	public void Play(string name) {
		Sound s = Array.Find (sounds, sound => sound.name == name);
		s.audioSource.Play ();
	}

	public void Stop(string name) {
		Sound s = Array.Find (sounds, sound => sound.name == name);
		s.audioSource.Stop ();
	}

	public Sound FindSound(string name) {
		Sound s = Array.Find (sounds, sound => sound.name == name);
		return s;
	}

	public void SetVolume(Sound sound, bool increase) {
		AudioSource audioSource = sound.audioSource;

		float audioVolume = audioSource.volume;

		if (increase) {
			if (audioVolume > 0) {
				audioVolume -= 0.5f * Time.deltaTime;
			}
		} else {
			if (audioVolume < sound.volume) {
				audioVolume += 0.5f * Time.deltaTime;
			}	
		}

		audioSource.volume = audioVolume;
		Debug.Log (audioVolume);
	}

}
