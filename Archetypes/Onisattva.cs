using System;
using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Microsoft.Build.Utilities;

namespace OnisattvaMod.Archetypes
{
    internal class Onisattva
    {
        // New, stable GUIDs (generate once, keep forever)
        internal const string ArchetypeGuid = "11111111-2222-3333-4444-555555555555";
        internal const string FeatureGuid = "aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee";

        // Blueprint names (keys) — back these with LocalizedStrings later
        internal const string ArchetypeName = "OnisattvaArchetype";
        internal const string ArchetypeDisplayName = "Onisattva.Name";
        internal const string ArchetypeDescription = "Onisattva.Description";
        internal const string FeatureName = "Onisattva.Level1Feature";
        internal const string FeatureDesc = "Onisattva.Level1Feature.Description";

        internal static readonly LogWrapper Logger = LogWrapper.Get("OnisattvaMod.Onisattva");

        internal static void Configure()
        {
            try
            {
                ConfigureEnabled();
            } 
            catch (Exception e)
            {
                Logger.Error("Failed to configure Onisattva", e);
            }
        }
        
        private static void ConfigureEnabled(){
            Logger.Info($"Configuring {ArchetypeName}");

            var archetype = ArchetypeConfigurator.New(ArchetypeName, ArchetypeGuid, CharacterClassRefs.KineticistClass)
                .SetLocalizedName(ArchetypeDisplayName).SetLocalizedDescription(ArchetypeDescription);

            archetype.AddToRemoveFeatures(1, FeatureRefs.Infusion.ToString())
                .AddToRemoveFeatures(3, FeatureRefs.Infusion.ToString());

        }

    }
}
