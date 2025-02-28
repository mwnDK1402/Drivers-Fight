﻿using Photon.Pun;
using UnityEngine;

namespace DriversFight.Scripts
{
    public class AvatarExposerScript : MonoBehaviour
    {
        public Rigidbody AvatarRigidBody;
        public Transform AvatarRootTransform;
        public GameObject AvatarRootGameObject;
        public PhotonTransformView AvatarTransformView;
        public Character Stats;
        public PhotonView photonView;
        public CollisionEnterDispatcherScript CollisionDispatcher;
        public Collider MainCollider;
        public bool IsAlive = true;
    }
}
