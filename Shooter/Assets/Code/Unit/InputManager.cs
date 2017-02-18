﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMKShooter {
	public class InputManager : MonoBehaviour {
		private string _hori;
		private string _verti;
		private string _shoot;

		private bool _shooting;
		public bool Shooting { get { return _shooting; } }

		private Vector3 _directionalInput;
		public Vector3 DirectionalInput { get { return _directionalInput; } }

		public enum Controller {
			WASD,
			UpDownLR,
			Gamepad1,
			Gamepad2
		}

		public Controller _controlledBy;

		// Use this for initialization
		void Start () {
			if (_controlledBy == Controller.WASD) {
				_hori = "WASD_Hori";
				_verti = "WASD_Verti";
				_shoot = "WASD_Shoot";
			} else if (_controlledBy == Controller.UpDownLR) {
				_hori = "ULDR_Hori";
				_verti = "ULDR_Verti";
				_shoot = "ULDR_Shoot";
			} else if (_controlledBy == Controller.Gamepad1) {
				_hori = "Gamepad1_Hori";
				_verti = "Gamepad1_Verti";
				_shoot = "Gamepad1_Shoot";
			} else if (_controlledBy == Controller.Gamepad2) {
				_hori = "Gamepad2_Hori";
				_verti = "Gamepad2_Verti";
				_shoot = "Gamepad2_Shoot";
			}
		}
		
		// Update is called once per frame
		void Update () {
			float horizontal = Input.GetAxis ( _hori );
			float vertical = Input.GetAxis ( _verti );

			_directionalInput = new Vector3 ( horizontal, 0, vertical );

			_shooting = Input.GetButton ( _shoot );
		}
	}
}