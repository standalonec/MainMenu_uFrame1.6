﻿using UnityEditor;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    [CustomEditor(typeof(ProCamera2DPanAndZoom))]
    public class ProCamera2DPanAndZoomEditor : Editor
    {
        GUIContent _tooltip;

        MonoScript _script;

        void OnEnable()
        {
            ProCamera2DEditorHelper.AssignProCamera2D(target as BasePC2D);

            _script = MonoScript.FromMonoBehaviour((ProCamera2DPanAndZoom)target);
        }

        public override void OnInspectorGUI()
        {
            var proCamera2DPanAndZoom = (ProCamera2DPanAndZoom)target;

            serializedObject.Update();

            // Show script link
            GUI.enabled = false;
            _script = EditorGUILayout.ObjectField("Script", _script, typeof(MonoScript), false) as MonoScript;
            GUI.enabled = true;

            // ProCamera2D
            _tooltip = new GUIContent("Pro Camera 2D", "");
            EditorGUILayout.PropertyField(serializedObject.FindProperty("ProCamera2D"), _tooltip);

            if (proCamera2DPanAndZoom.ProCamera2D == null)
                EditorGUILayout.HelpBox("ProCamera2D is not set.", MessageType.Error, true);

            EditorGUILayout.Space();

            // Allow Zoom
            _tooltip = new GUIContent("Allow Zoom", "If enabled, the user will be able to manually zoom the camera");
            EditorGUILayout.PropertyField(serializedObject.FindProperty("AllowZoom"), _tooltip);

            if (proCamera2DPanAndZoom.AllowZoom)
            {
                EditorGUI.indentLevel = 1;

                // Mouse zoom speed
                _tooltip = new GUIContent("Mouse Zoom Speed", "The speed at which to zoom when using the mouse wheel (Desktop Only)");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("MouseZoomSpeed"), _tooltip);

                // Pinch zoom speed
                _tooltip = new GUIContent("Pinch Zoom Speed", "The speed at which to zoom when using the pinch gesture (Mobile Only)");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("PinchZoomSpeed"), _tooltip);

                // Zoom smoothness
                _tooltip = new GUIContent("Zoom Smoothness", "The smoothness of the zoom");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ZoomSmoothness"), _tooltip);

                // Max zoom in amount
                _tooltip = new GUIContent("Max Zoom In Amount", "Represents the maximum amount the camera should zoom in");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("MaxZoomInAmount"), _tooltip);

                // Max zoom in amount
                _tooltip = new GUIContent("Max Zoom Out Amount", "Represents the maximum amount the camera should zoom out");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("MaxZoomOutAmount"), _tooltip);

                // Zoom to input center
                _tooltip = new GUIContent("Zoom To Input Center", "If enabled, the camera will zoom to the current input position (mouse or touch). If disabled, the camera will zoom to its center");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("ZoomToInputCenter"), _tooltip);

                EditorGUI.indentLevel = 0;

                EditorGUILayout.Space();
            }

            // Allow Pan
            _tooltip = new GUIContent("Allow Pan", "If enabled, the user will be able to manually pan the camera");
            EditorGUILayout.PropertyField(serializedObject.FindProperty("AllowPan"), _tooltip);

            if (proCamera2DPanAndZoom.AllowPan)
            {
                EditorGUI.indentLevel = 1;

                // Use pan by drag
                _tooltip = new GUIContent("Use Drag Pan", "Pan the camera by dragging the 'world'");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("UsePanByDrag"), _tooltip);

                if (proCamera2DPanAndZoom.UsePanByDrag)
                {
                    EditorGUI.indentLevel = 2;
                    _tooltip = new GUIContent("Drag Pan Speed", "The speed at which to pan the camera");
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("DragPanSpeed"), _tooltip);

                    _tooltip = new GUIContent("Draggable Area", "A normalized screen space area where the drag is active. Leave to default to use the whole screen");
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("DraggableAreaRect"), _tooltip);
                    EditorGUI.indentLevel = 1;
                }

                // Use pan by move to edges
                _tooltip = new GUIContent("Use Edges Pan", "Pan the camera by moving the mouse to the edges of the screen (Desktop only)");
                EditorGUILayout.PropertyField(serializedObject.FindProperty("UsePanByMoveToEdges"), _tooltip);

                if (proCamera2DPanAndZoom.UsePanByMoveToEdges)
                {
                    EditorGUI.indentLevel = 2;
                    _tooltip = new GUIContent("Edges Pan Speed", "The speed at which the camera will move when the mouse reaches the edges of the screen");
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("EdgesPanSpeed"), _tooltip);

                    _tooltip = new GUIContent("Horizontal Pan Edges", "If the mouse pointer goes beyond this edge the camera will start moving horizontally");
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("HorizontalPanEdges"), _tooltip);

                    _tooltip = new GUIContent("Vertical Pan Edges", "If the mouse pointer goes beyond this edge the camera will start moving vertically");
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("VerticalPanEdges"), _tooltip);
                }

                EditorGUI.indentLevel = 0;
            }

            // Apply properties
            serializedObject.ApplyModifiedProperties();

            // Limit
            if (proCamera2DPanAndZoom.MaxZoomInAmount < 1f)
                proCamera2DPanAndZoom.MaxZoomInAmount = 1f;

            if (proCamera2DPanAndZoom.MaxZoomOutAmount < 1f)
                proCamera2DPanAndZoom.MaxZoomOutAmount = 1f;

            if (proCamera2DPanAndZoom.ZoomSmoothness < 0f)
                proCamera2DPanAndZoom.ZoomSmoothness = 0f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.width < 0f)
                proCamera2DPanAndZoom.DraggableAreaRect.width = 0f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.width > 1f)
                proCamera2DPanAndZoom.DraggableAreaRect.width = 1f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.height < 0f)
                proCamera2DPanAndZoom.DraggableAreaRect.height = 0f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.height > 1f)
                proCamera2DPanAndZoom.DraggableAreaRect.height = 1f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.x < -.5f)
                proCamera2DPanAndZoom.DraggableAreaRect.x = -.5f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.x > .5f)
                proCamera2DPanAndZoom.DraggableAreaRect.x = .5f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.y < -.5f)
                proCamera2DPanAndZoom.DraggableAreaRect.y = -.5f;

            if (proCamera2DPanAndZoom.DraggableAreaRect.y > .5f)
                proCamera2DPanAndZoom.DraggableAreaRect.y = .5f;

            // Warning
            if (!proCamera2DPanAndZoom.AllowPan && !proCamera2DPanAndZoom.AllowZoom)
            {
                EditorGUILayout.HelpBox("This won't be the most useful extension now, will it?", MessageType.Warning, true);
            }
        }
    }
}