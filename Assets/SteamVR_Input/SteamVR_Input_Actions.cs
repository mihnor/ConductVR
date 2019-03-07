//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Single p_conductor_Conduct;
        
        private static SteamVR_Action_Pose p_conductor_PoseLeft;
        
        private static SteamVR_Action_Pose p_conductor_PoseRight;
        
        public static SteamVR_Action_Single conductor_Conduct
        {
            get
            {
                return SteamVR_Actions.p_conductor_Conduct.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Pose conductor_PoseLeft
        {
            get
            {
                return SteamVR_Actions.p_conductor_PoseLeft.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Pose conductor_PoseRight
        {
            get
            {
                return SteamVR_Actions.p_conductor_PoseRight.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.conductor_Conduct,
                    SteamVR_Actions.conductor_PoseLeft,
                    SteamVR_Actions.conductor_PoseRight};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.conductor_Conduct,
                    SteamVR_Actions.conductor_PoseLeft,
                    SteamVR_Actions.conductor_PoseRight};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[0];
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[0];
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.conductor_PoseLeft,
                    SteamVR_Actions.conductor_PoseRight};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[0];
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[] {
                    SteamVR_Actions.conductor_Conduct};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[0];
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[0];
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.conductor_Conduct};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_conductor_Conduct = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/conductor/in/Conduct")));
            SteamVR_Actions.p_conductor_PoseLeft = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/conductor/in/PoseLeft")));
            SteamVR_Actions.p_conductor_PoseRight = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/conductor/in/PoseRight")));
        }
    }
}
