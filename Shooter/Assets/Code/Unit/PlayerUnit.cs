using System;
using TAMKShooter.Data;
using UnityEngine;
using TAMKShooter.Configs;

namespace TAMKShooter
{
	public class PlayerUnit : UnitBase
	{
		public enum UnitType
		{
			None = 0,
			Fast = 1,
			Balanced = 2,
			Heavy = 3
		}

		[SerializeField] private UnitType _type;

		private InputManager _inputManager;

		private void Start() {
			_inputManager = GetComponent<InputManager> ();
		}

		public UnitType Type { get { return _type; } }
		public PlayerData Data { get; private set; }

		public override int ProjectileLayer
		{
			get
			{
				return LayerMask.NameToLayer ( Config.PlayerProjectileLayerName );
			}
		}

		public void Init( PlayerData playerData )
		{
			Data = playerData;
		}

		protected override void Die ()
		{
			// TODO: Handle dying properly!
			// Instantiate explosion effect
			// Play sound
			// Decrease lives
			// Respawn player
			gameObject.SetActive ( false );

			base.Die ();
		}

		protected void Update()
		{
			Mover.MoveToDirection ( _inputManager.DirectionalInput );

			if(_inputManager.Shooting)
			{
				Weapons.Shoot ( ProjectileLayer );
			}
		}
	}
}
