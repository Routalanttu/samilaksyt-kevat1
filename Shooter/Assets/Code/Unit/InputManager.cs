using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMKShooter {
	public class InputManager : MonoBehaviour {

		private PlayerUnit _playerUnit;
		private PlayerUnit.Controller _controlledBy;

		public string _hori = "WASD_Hori";
		public string _verti = "WASD_Verti";
		public string _shoot = "WASD_Shoot";

		public string Hori { get { return _hori; } }
		public string Verti { get { return _verti; } }
		public string Shoot { get { return _shoot; } }

		// Use this for initialization
		void Start () {
			_playerUnit = GetComponent<PlayerUnit> ();
			_controlledBy = _playerUnit._controlledBy;
			if (_controlledBy == PlayerUnit.Controller.WASD) {
				_hori = "WASD_Hori";
				_verti = "WASD_Verti";
				_shoot = "WASD_Shoot";
			} else if (_controlledBy == PlayerUnit.Controller.UpDownLR) {
				_hori = "ULDR_Hori";
				_verti = "ULDR_Verti";
				_shoot = "ULDR_Shoot";
			} else if (_controlledBy == PlayerUnit.Controller.Gamepad1) {
				_hori = "Gamepad1_Hori";
				_verti = "Gamepad1_Verti";
				_shoot = "Gamepad1_Shoot";
			} else if (_controlledBy == PlayerUnit.Controller.Gamepad2) {
				_hori = "Gamepad2_Hori";
				_verti = "Gamepad2_Verti";
				_shoot = "Gamepad2_Shoot";
			}
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
}