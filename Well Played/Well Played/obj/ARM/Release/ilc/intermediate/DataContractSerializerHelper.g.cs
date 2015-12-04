using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 1717
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                13, // array length: 13
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                13, // array length: 13
                1818, // index: 1818, string: "AppVersion"
                280, // index: 280, string: "BaseConfiguration"
                1829, // index: 1829, string: "CdnUriFormat"
                1842, // index: 1842, string: "ConfigId"
                1851, // index: 1851, string: "FileVersion"
                1863, // index: 1863, string: "LegacyConfigId"
                1878, // index: 1878, string: "MarketOverrides"
                1894, // index: 1894, string: "RefreshRate"
                1906, // index: 1906, string: "SchemaVersion"
                1920, // index: 1920, string: "TestConfiguration"
                1938, // index: 1938, string: "UpdatedDateTime"
                1954, // index: 1954, string: "UseRoundRobin"
                1968, // index: 1968, string: "Version"
                13, // array length: 13
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                6, // array length: 6
                1976, // index: 1976, string: "AdAdapters"
                1987, // index: 1987, string: "AdControlConfigurations"
                2011, // index: 2011, string: "ConfigurationUri"
                2028, // index: 2028, string: "RotationAlgorithm"
                2046, // index: 2046, string: "UnusedAdAdapters"
                1968, // index: 1968, string: "Version"
                6, // array length: 6
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                5, // array length: 5
                2063, // index: 2063, string: "Metadata"
                2072, // index: 2072, string: "Name"
                2077, // index: 2077, string: "Rank"
                2082, // index: 2082, string: "Timeout"
                2090, // index: 2090, string: "Weight"
                5, // array length: 5
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                2, // array length: 2
                1108, // index: 1108, string: "Key"
                1112, // index: 1112, string: "Value"
                2, // array length: 2
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                3, // array length: 3
                1976, // index: 1976, string: "AdAdapters"
                2097, // index: 2097, string: "Id"
                2072, // index: 2072, string: "Name"
                3, // array length: 3
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                7, // array length: 7
                1976, // index: 1976, string: "AdAdapters"
                1987, // index: 1987, string: "AdControlConfigurations"
                2011, // index: 2011, string: "ConfigurationUri"
                2028, // index: 2028, string: "RotationAlgorithm"
                2046, // index: 2046, string: "UnusedAdAdapters"
                1968, // index: 1968, string: "Version"
                2100, // index: 2100, string: "Region"
                7, // array length: 7
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                2, // array length: 2
                2107, // index: 2107, string: "AdMediatorDeviceId"
                555, // index: 555, string: "ConfigFileState"
                2, // array length: 2
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                2126, // index: 2126, string: "ActiveConfigStorageFolder"
                571, // index: 571, string: "FileFetchInformation"
                2152, // index: 2152, string: "LastKnownGoodConfigStorageFolder"
                3, // array length: 3
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                2185, // index: 2185, string: "LastAttemptedFetch"
                2204, // index: 2204, string: "LastSuccessfulFetch"
                2224, // index: 2224, string: "WasLastAttemptSuccessful"
                3, // array length: 3
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                479, // index: 479, string: "http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                279, // index: 279, string: ""
                3, // array length: 3
                2249, // index: 2249, string: "ErrorCode"
                2259, // index: 2259, string: "ErrorText"
                2072, // index: 2072, string: "Name"
                3, // array length: 3
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                279, // index: 279, string: ""
                8, // array length: 8
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                8, // array length: 8
                2269, // index: 2269, string: "champions"
                2279, // index: 2279, string: "data"
                2284, // index: 2284, string: "format"
                2291, // index: 2291, string: "keys"
                2296, // index: 2296, string: "modifyDate"
                2307, // index: 2307, string: "summonerId"
                2318, // index: 2318, string: "type"
                2323, // index: 2323, string: "version"
                8, // array length: 8
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                18, // array length: 18
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                18, // array length: 18
                2331, // index: 2331, string: "allytips"
                2340, // index: 2340, string: "blurb"
                2346, // index: 2346, string: "enemytips"
                2356, // index: 2356, string: "id"
                2359, // index: 2359, string: "image"
                2365, // index: 2365, string: "info"
                2370, // index: 2370, string: "key"
                2374, // index: 2374, string: "lore"
                2379, // index: 2379, string: "name"
                2384, // index: 2384, string: "partype"
                2392, // index: 2392, string: "passive"
                2400, // index: 2400, string: "recommended"
                2412, // index: 2412, string: "skins"
                2418, // index: 2418, string: "spells"
                2425, // index: 2425, string: "stats"
                2431, // index: 2431, string: "tags"
                2436, // index: 2436, string: "thumbnail"
                2446, // index: 2446, string: "title"
                18, // array length: 18
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                8, // array length: 8
                2452, // index: 2452, string: "full"
                2457, // index: 2457, string: "group"
                2463, // index: 2463, string: "h"
                2465, // index: 2465, string: "sprite"
                2472, // index: 2472, string: "url"
                2476, // index: 2476, string: "w"
                2478, // index: 2478, string: "x"
                2480, // index: 2480, string: "y"
                8, // array length: 8
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                2482, // index: 2482, string: "attack"
                2489, // index: 2489, string: "defense"
                2497, // index: 2497, string: "difficulty"
                2508, // index: 2508, string: "magic"
                4, // array length: 4
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                2514, // index: 2514, string: "description"
                2359, // index: 2359, string: "image"
                2379, // index: 2379, string: "name"
                2526, // index: 2526, string: "sanitizedDescription"
                4, // array length: 4
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                7, // array length: 7
                2547, // index: 2547, string: "blocks"
                2554, // index: 2554, string: "champion"
                2563, // index: 2563, string: "map"
                2567, // index: 2567, string: "mode"
                2572, // index: 2572, string: "priority"
                2446, // index: 2446, string: "title"
                2318, // index: 2318, string: "type"
                7, // array length: 7
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                2581, // index: 2581, string: "items"
                2587, // index: 2587, string: "recMath"
                2318, // index: 2318, string: "type"
                3, // array length: 3
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                2595, // index: 2595, string: "count"
                2356, // index: 2356, string: "id"
                2, // array length: 2
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                2356, // index: 2356, string: "id"
                2379, // index: 2379, string: "name"
                2601, // index: 2601, string: "num"
                3, // array length: 3
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                21, // array length: 21
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                21, // array length: 21
                2605, // index: 2605, string: "altimages"
                2615, // index: 2615, string: "cooldown"
                2624, // index: 2624, string: "cooldownBurn"
                2637, // index: 2637, string: "cost"
                2642, // index: 2642, string: "costBurn"
                2651, // index: 2651, string: "costType"
                2514, // index: 2514, string: "description"
                2660, // index: 2660, string: "effect"
                2667, // index: 2667, string: "effectBurn"
                2359, // index: 2359, string: "image"
                2370, // index: 2370, string: "key"
                2678, // index: 2678, string: "leveltip"
                2687, // index: 2687, string: "maxrank"
                2379, // index: 2379, string: "name"
                2695, // index: 2695, string: "range"
                2701, // index: 2701, string: "rangeBurn"
                2711, // index: 2711, string: "resource"
                2526, // index: 2526, string: "sanitizedDescription"
                2720, // index: 2720, string: "sanitizedTooltip"
                2737, // index: 2737, string: "tooltip"
                2745, // index: 2745, string: "vars"
                21, // array length: 21
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                2660, // index: 2660, string: "effect"
                2750, // index: 2750, string: "label"
                2, // array length: 2
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                5, // array length: 5
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                5, // array length: 5
                2756, // index: 2756, string: "coeff"
                2762, // index: 2762, string: "dyn"
                2370, // index: 2370, string: "key"
                2766, // index: 2766, string: "link"
                2771, // index: 2771, string: "ranksWith"
                5, // array length: 5
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                53, // array length: 53
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                53, // array length: 53
                2781, // index: 2781, string: "armor"
                2787, // index: 2787, string: "armorperlevel"
                2801, // index: 2801, string: "attackdamage"
                2814, // index: 2814, string: "attackdamageperlevel"
                2835, // index: 2835, string: "attackrange"
                2847, // index: 2847, string: "attackspeedoffset"
                2865, // index: 2865, string: "attackspeedperlevel"
                2885, // index: 2885, string: "botGamesPlayed"
                2900, // index: 2900, string: "crit"
                2905, // index: 2905, string: "critperlevel"
                2918, // index: 2918, string: "hp"
                2921, // index: 2921, string: "hpperlevel"
                2932, // index: 2932, string: "hpregen"
                2940, // index: 2940, string: "hpregenperlevel"
                2956, // index: 2956, string: "killingSpree"
                2969, // index: 2969, string: "maxChampionsKilled"
                2988, // index: 2988, string: "maxLargestCriticalStrike"
                3013, // index: 3013, string: "maxLargestKillingSpree"
                3036, // index: 3036, string: "maxNumDeaths"
                3049, // index: 3049, string: "maxTimePlayed"
                3063, // index: 3063, string: "maxTimeSpentLiving"
                3082, // index: 3082, string: "mostChampionKillsPerSession"
                3110, // index: 3110, string: "mostSpellsCast"
                3125, // index: 3125, string: "movespeed"
                3135, // index: 3135, string: "mp"
                3138, // index: 3138, string: "mpperlevel"
                3149, // index: 3149, string: "mpregen"
                3157, // index: 3157, string: "mpregenperlevel"
                3173, // index: 3173, string: "normalGamesPlayed"
                3191, // index: 3191, string: "rankedPremadeGamesPlayed"
                3216, // index: 3216, string: "rankedSoloGamesPlayed"
                3238, // index: 3238, string: "spellblock"
                3249, // index: 3249, string: "spellblockperlevel"
                3268, // index: 3268, string: "totalAssists"
                3281, // index: 3281, string: "totalChampionKills"
                3300, // index: 3300, string: "totalDamageDealt"
                3317, // index: 3317, string: "totalDamageTaken"
                3334, // index: 3334, string: "totalDeathsPerSession"
                3356, // index: 3356, string: "totalDoubleKills"
                3373, // index: 3373, string: "totalFirstBlood"
                3389, // index: 3389, string: "totalGoldEarned"
                3405, // index: 3405, string: "totalHeal"
                3415, // index: 3415, string: "totalMagicDamageDealt"
                3437, // index: 3437, string: "totalMinionKills"
                3454, // index: 3454, string: "totalPentaKills"
                3470, // index: 3470, string: "totalPhysicalDamageDealt"
                3495, // index: 3495, string: "totalQuadraKills"
                3512, // index: 3512, string: "totalSessionsLost"
                3530, // index: 3530, string: "totalSessionsPlayed"
                3550, // index: 3550, string: "totalSessionsWon"
                3567, // index: 3567, string: "totalTripleKills"
                3584, // index: 3584, string: "totalTurretsKilled"
                3603, // index: 3603, string: "totalUnrealKills"
                53, // array length: 53
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                1, // array length: 1
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1108, // index: 1108, string: "Key"
                1112, // index: 1112, string: "Value"
                2, // array length: 2
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                1, // array length: 1
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2370, // index: 2370, string: "key"
                3620, // index: 3620, string: "value"
                2, // array length: 2
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1108, // index: 1108, string: "Key"
                1112, // index: 1112, string: "Value"
                2, // array length: 2
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2370, // index: 2370, string: "key"
                3620, // index: 3620, string: "value"
                2, // array length: 2
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                6, // array length: 6
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                6, // array length: 6
                3626, // index: 3626, string: "basic"
                2279, // index: 2279, string: "data"
                3632, // index: 3632, string: "groups"
                3639, // index: 3639, string: "tree"
                2318, // index: 2318, string: "type"
                2323, // index: 2323, string: "version"
                6, // array length: 6
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                23, // array length: 23
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                23, // array length: 23
                3644, // index: 3644, string: "colloq"
                3651, // index: 3651, string: "consumeOnFull"
                3665, // index: 3665, string: "consumed"
                3674, // index: 3674, string: "depth"
                2514, // index: 2514, string: "description"
                3680, // index: 3680, string: "from"
                3685, // index: 3685, string: "gold"
                2457, // index: 2457, string: "group"
                3690, // index: 3690, string: "hideFromAll"
                2356, // index: 2356, string: "id"
                2359, // index: 2359, string: "image"
                3702, // index: 3702, string: "inStore"
                2365, // index: 2365, string: "info"
                3710, // index: 3710, string: "maps"
                2379, // index: 2379, string: "name"
                3715, // index: 3715, string: "plaintext"
                3725, // index: 3725, string: "requiredChampion"
                3742, // index: 3742, string: "rune"
                2526, // index: 2526, string: "sanitizedDescription"
                3747, // index: 3747, string: "specialRecipe"
                3761, // index: 3761, string: "stacks"
                2425, // index: 2425, string: "stats"
                2431, // index: 2431, string: "tags"
                23, // array length: 23
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                3768, // index: 3768, string: "baseGold"
                3777, // index: 3777, string: "purchasable"
                3789, // index: 3789, string: "sell"
                3794, // index: 3794, string: "total"
                4, // array length: 4
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1108, // index: 1108, string: "Key"
                1112, // index: 1112, string: "Value"
                2, // array length: 2
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2370, // index: 2370, string: "key"
                3620, // index: 3620, string: "value"
                2, // array length: 2
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                3800, // index: 3800, string: "isRune"
                3807, // index: 3807, string: "tier"
                2318, // index: 2318, string: "type"
                3, // array length: 3
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                63, // array length: 63
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                63, // array length: 63
                3812, // index: 3812, string: "FlatArmorMod"
                3825, // index: 3825, string: "FlatAttackSpeedMod"
                3844, // index: 3844, string: "FlatBlockMod"
                3857, // index: 3857, string: "FlatCritChanceMod"
                3875, // index: 3875, string: "FlatCritDamageMod"
                3893, // index: 3893, string: "FlatEXPBonus"
                3906, // index: 3906, string: "FlatEnergyPoolMod"
                3924, // index: 3924, string: "FlatEnergyRegenMod"
                3943, // index: 3943, string: "FlatHPPoolMod"
                3957, // index: 3957, string: "FlatHPRegenMod"
                3972, // index: 3972, string: "FlatMPPoolMod"
                3986, // index: 3986, string: "FlatMPRegenMod"
                4001, // index: 4001, string: "FlatMagicDamageMod"
                4020, // index: 4020, string: "FlatMovementSpeedMod"
                4041, // index: 4041, string: "FlatPhysicalDamageMod"
                4063, // index: 4063, string: "FlatSpellBlockMod"
                4081, // index: 4081, string: "PercentArmorMod"
                4097, // index: 4097, string: "PercentAttackSpeedMod"
                4119, // index: 4119, string: "PercentBlockMod"
                4135, // index: 4135, string: "PercentCritChanceMod"
                4156, // index: 4156, string: "PercentCritDamageMod"
                4177, // index: 4177, string: "PercentDodgeMod"
                4193, // index: 4193, string: "PercentEXPBonus"
                4209, // index: 4209, string: "PercentHPPoolMod"
                4226, // index: 4226, string: "PercentHpRegenMod"
                4244, // index: 4244, string: "PercentLifeStealMod"
                4264, // index: 4264, string: "PercentMPPool"
                4278, // index: 4278, string: "PercentMPRegen"
                4293, // index: 4293, string: "PercentMagicDamageMod"
                4315, // index: 4315, string: "PercentMovementSpeedMod"
                4339, // index: 4339, string: "PercentPhysicalDamageMod"
                4364, // index: 4364, string: "PercentSpellBlockMod"
                4385, // index: 4385, string: "PercentSpellVampMod"
                4405, // index: 4405, string: "rFlatArmorModPerLevel"
                4427, // index: 4427, string: "rFlatArmorPenetrationMod"
                4452, // index: 4452, string: "rFlatArmorPenetrationModPerLevel"
                4485, // index: 4485, string: "rFlatCritChanceModPerLevel"
                4512, // index: 4512, string: "rFlatCritDamageModPerLevel"
                4539, // index: 4539, string: "rFlatDodgeMod"
                4553, // index: 4553, string: "rFlatDodgeModPerLevel"
                4575, // index: 4575, string: "rFlatEnergyModPerLevel"
                4598, // index: 4598, string: "rFlatEnergyRegenModPerLevel"
                4626, // index: 4626, string: "rFlatGoldPer10Mod"
                4644, // index: 4644, string: "rFlatHPModPerLevel"
                4663, // index: 4663, string: "rFlatMPRegenModPerLevel"
                4687, // index: 4687, string: "rFlatMagicDamageModPerLevel"
                4715, // index: 4715, string: "rFlatMagicPenetrationMod"
                4740, // index: 4740, string: "rFlatMagicPenetrationModPerLevel"
                4773, // index: 4773, string: "rFlatMovementSpeedModPerLevel"
                4803, // index: 4803, string: "rFlatPhysicalDamageModPerLevel"
                4834, // index: 4834, string: "rFlatSpellBlockModPerLevel"
                4861, // index: 4861, string: "rFlatTimeDeadMod"
                4878, // index: 4878, string: "rFlatTimeDeadModPerLevel"
                4903, // index: 4903, string: "rPercentArmorPenetrationMod"
                4931, // index: 4931, string: "rPercentArmorPenetrationModPerLevel"
                4967, // index: 4967, string: "rPercentAttackSpeedModPerLevel"
                4998, // index: 4998, string: "rPercentCooldownMod"
                5018, // index: 5018, string: "rPercentCooldownModPerLevel"
                5046, // index: 5046, string: "rPercentMagicPenetrationMod"
                5074, // index: 5074, string: "rPercentMagicPenetrationModPerLevel"
                5110, // index: 5110, string: "rPercentMovementSpeedModPerLevel"
                5143, // index: 5143, string: "rPercentTimeDeadMod"
                5163, // index: 5163, string: "rPercentTimeDeadModPerLevel"
                63, // array length: 63
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                1, // array length: 1
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1108, // index: 1108, string: "Key"
                1112, // index: 1112, string: "Value"
                2, // array length: 2
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                24, // array length: 24
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                24, // array length: 24
                3644, // index: 3644, string: "colloq"
                3651, // index: 3651, string: "consumeOnFull"
                3665, // index: 3665, string: "consumed"
                3674, // index: 3674, string: "depth"
                2514, // index: 2514, string: "description"
                3680, // index: 3680, string: "from"
                3685, // index: 3685, string: "gold"
                2457, // index: 2457, string: "group"
                3690, // index: 3690, string: "hideFromAll"
                2356, // index: 2356, string: "id"
                2359, // index: 2359, string: "image"
                5191, // index: 5191, string: "imageURL"
                3702, // index: 3702, string: "inStore"
                5200, // index: 5200, string: "into"
                3710, // index: 3710, string: "maps"
                2379, // index: 2379, string: "name"
                3715, // index: 3715, string: "plaintext"
                3725, // index: 3725, string: "requiredChampion"
                3742, // index: 3742, string: "rune"
                2526, // index: 2526, string: "sanitizedDescription"
                3747, // index: 3747, string: "specialRecipe"
                3761, // index: 3761, string: "stacks"
                2425, // index: 2425, string: "stats"
                2431, // index: 2431, string: "tags"
                24, // array length: 24
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                1, // array length: 1
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2370, // index: 2370, string: "key"
                3620, // index: 3620, string: "value"
                2, // array length: 2
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                2370, // index: 2370, string: "key"
                5205, // index: 5205, string: "maxGroupOwnable"
                2, // array length: 2
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                5221, // index: 5221, string: "header"
                2431, // index: 2431, string: "tags"
                2, // array length: 2
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                16, // array length: 16
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                16, // array length: 16
                5228, // index: 5228, string: "division"
                2356, // index: 2356, string: "id"
                5237, // index: 5237, string: "isFreshBlood"
                5250, // index: 5250, string: "isHotStreak"
                5262, // index: 5262, string: "isInactive"
                5273, // index: 5273, string: "isVeteran"
                5283, // index: 5283, string: "leaguePoints"
                5296, // index: 5296, string: "losses"
                2379, // index: 2379, string: "name"
                5303, // index: 5303, string: "playerOrTeamId"
                5318, // index: 5318, string: "playerOrTeamName"
                5335, // index: 5335, string: "profileIconId"
                5349, // index: 5349, string: "revisionDate"
                5362, // index: 5362, string: "summonerLevel"
                3807, // index: 3807, string: "tier"
                5376, // index: 5376, string: "wins"
                16, // array length: 16
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                4, // array length: 4
                2379, // index: 2379, string: "name"
                5381, // index: 5381, string: "queue"
                5387, // index: 5387, string: "summoners"
                3807, // index: 3807, string: "tier"
                4, // array length: 4
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                5397, // index: 5397, string: "games"
                2307, // index: 2307, string: "summonerId"
                2, // array length: 2
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                21, // array length: 21
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                21, // array length: 21
                5403, // index: 5403, string: "championId"
                5414, // index: 5414, string: "color"
                5420, // index: 5420, string: "createDate"
                5431, // index: 5431, string: "fellowPlayers"
                5445, // index: 5445, string: "gameDate"
                5454, // index: 5454, string: "gameId"
                5461, // index: 5461, string: "gameMode"
                5470, // index: 5470, string: "gameType"
                5479, // index: 5479, string: "invalid"
                5487, // index: 5487, string: "ipEarned"
                5496, // index: 5496, string: "level"
                5502, // index: 5502, string: "mapId"
                5508, // index: 5508, string: "spell1"
                5515, // index: 5515, string: "spell1img"
                5525, // index: 5525, string: "spell2"
                5532, // index: 5532, string: "spell2img"
                2425, // index: 2425, string: "stats"
                5542, // index: 5542, string: "subType"
                5550, // index: 5550, string: "teamId"
                2436, // index: 2436, string: "thumbnail"
                5557, // index: 5557, string: "win"
                21, // array length: 21
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                5403, // index: 5403, string: "championId"
                2307, // index: 2307, string: "summonerId"
                5550, // index: 5550, string: "teamId"
                3, // array length: 3
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                86, // array length: 86
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                86, // array length: 86
                5561, // index: 5561, string: "assists"
                5569, // index: 5569, string: "barracksKilled"
                5584, // index: 5584, string: "championsKilled"
                5600, // index: 5600, string: "combatPlayerScore"
                5618, // index: 5618, string: "consumablesPurchased"
                5639, // index: 5639, string: "damageDealtPlayer"
                5657, // index: 5657, string: "doubleKills"
                5669, // index: 5669, string: "firstBlood"
                5680, // index: 5680, string: "gameTime"
                3685, // index: 3685, string: "gold"
                5689, // index: 5689, string: "goldEarned"
                5700, // index: 5700, string: "goldSpend"
                5710, // index: 5710, string: "item0"
                5716, // index: 5716, string: "item0imageURL"
                5730, // index: 5730, string: "item1"
                5736, // index: 5736, string: "item1imageURL"
                5750, // index: 5750, string: "item2"
                5756, // index: 5756, string: "item2imageURL"
                5770, // index: 5770, string: "item3"
                5776, // index: 5776, string: "item3imageURL"
                5790, // index: 5790, string: "item4"
                5796, // index: 5796, string: "item4imageURL"
                5810, // index: 5810, string: "item5"
                5816, // index: 5816, string: "item5imageURL"
                5830, // index: 5830, string: "item6"
                5836, // index: 5836, string: "item6imageURL"
                5850, // index: 5850, string: "itemsPurchased"
                5865, // index: 5865, string: "killingSprees"
                5879, // index: 5879, string: "largestCriticalStrike"
                5901, // index: 5901, string: "largestKillingSpree"
                5921, // index: 5921, string: "largestMultiKill"
                5938, // index: 5938, string: "legendaryItemsCreated"
                5496, // index: 5496, string: "level"
                5960, // index: 5960, string: "magicDamageDealtPlayer"
                5983, // index: 5983, string: "magicDamageDealtToChampions"
                6011, // index: 6011, string: "magicDamageTaken"
                6028, // index: 6028, string: "minionsDenied"
                6042, // index: 6042, string: "minionsKilled"
                6056, // index: 6056, string: "neutralMinionsKilled"
                6077, // index: 6077, string: "neutralMinionsKilledEnemyJungle"
                6109, // index: 6109, string: "neutralMinionsKilledYourJungle"
                6140, // index: 6140, string: "nexusKilled"
                6152, // index: 6152, string: "nodeCapture"
                6164, // index: 6164, string: "nodeCaptureAssist"
                6182, // index: 6182, string: "nodeNeutralize"
                6197, // index: 6197, string: "nodeNeutralizeAssist"
                6218, // index: 6218, string: "numDeaths"
                6228, // index: 6228, string: "numItemsBought"
                6243, // index: 6243, string: "objectivePlayerScore"
                6264, // index: 6264, string: "pentaKills"
                6275, // index: 6275, string: "physicalDamageDealtPlayer"
                6301, // index: 6301, string: "physicalDamageDealtToChampions"
                6332, // index: 6332, string: "physicalDamageTaken"
                6352, // index: 6352, string: "playerPosition"
                6367, // index: 6367, string: "playerRole"
                6378, // index: 6378, string: "quadraKills"
                6390, // index: 6390, string: "sightWardsBought"
                6407, // index: 6407, string: "spell1Cast"
                6418, // index: 6418, string: "spell2Cast"
                6429, // index: 6429, string: "spell3Cast"
                6440, // index: 6440, string: "spell4Cast"
                6451, // index: 6451, string: "summonSpell1Cast"
                6468, // index: 6468, string: "summonSpell2Cast"
                6485, // index: 6485, string: "superMonsterKilled"
                6504, // index: 6504, string: "team"
                6509, // index: 6509, string: "teamObjective"
                6523, // index: 6523, string: "timePlayed"
                3300, // index: 3300, string: "totalDamageDealt"
                6534, // index: 6534, string: "totalDamageDealtToChampions"
                3317, // index: 3317, string: "totalDamageTaken"
                3405, // index: 3405, string: "totalHeal"
                6562, // index: 6562, string: "totalPlayerScore"
                6579, // index: 6579, string: "totalScoreRank"
                6594, // index: 6594, string: "totalTimeCrowdControlDealt"
                6621, // index: 6621, string: "totalUnitsHealed"
                6638, // index: 6638, string: "tripleKills"
                6650, // index: 6650, string: "trueDamageDealtPlayer"
                6672, // index: 6672, string: "trueDamageDealtToChampions"
                6699, // index: 6699, string: "trueDamageTaken"
                6715, // index: 6715, string: "turretsKilled"
                6729, // index: 6729, string: "unrealKills"
                6741, // index: 6741, string: "victoryPointTotal"
                6759, // index: 6759, string: "visionWardsBought"
                6777, // index: 6777, string: "wardKilled"
                6788, // index: 6788, string: "wardPlaced"
                5557, // index: 5557, string: "win"
                86, // array length: 86
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                23, // array length: 23
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                23, // array length: 23
                2615, // index: 2615, string: "cooldown"
                2624, // index: 2624, string: "cooldownBurn"
                2637, // index: 2637, string: "cost"
                2642, // index: 2642, string: "costBurn"
                2651, // index: 2651, string: "costType"
                2514, // index: 2514, string: "description"
                2660, // index: 2660, string: "effect"
                2667, // index: 2667, string: "effectBurn"
                2356, // index: 2356, string: "id"
                2359, // index: 2359, string: "image"
                2370, // index: 2370, string: "key"
                2678, // index: 2678, string: "leveltip"
                2687, // index: 2687, string: "maxrank"
                6799, // index: 6799, string: "modes"
                2379, // index: 2379, string: "name"
                2695, // index: 2695, string: "range"
                2701, // index: 2701, string: "rangeBurn"
                2711, // index: 2711, string: "resource"
                2526, // index: 2526, string: "sanitizedDescription"
                2720, // index: 2720, string: "sanitizedTooltip"
                5362, // index: 5362, string: "summonerLevel"
                2737, // index: 2737, string: "tooltip"
                2745, // index: 2745, string: "vars"
                23, // array length: 23
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                3, // array length: 3
                2279, // index: 2279, string: "data"
                2318, // index: 2318, string: "type"
                2323, // index: 2323, string: "version"
                3, // array length: 3
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                2, // array length: 2
                -1, // string: null
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                1, // array length: 1
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1108, // index: 1108, string: "Key"
                1112, // index: 1112, string: "Value"
                2, // array length: 2
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                728, // index: 728, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                630, // index: 630, string: "http://schemas.datacontract.org/2004/07/Well_Played.Models"
                1, // array length: 1
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                2370, // index: 2370, string: "key"
                3620, // index: 3620, string: "value"
                2, // array length: 2
                1155, // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1155  // index: 1155, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContractMap_Hashtable = new byte[0];
        // Count=124
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdMediatorConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.BaseConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                " PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                "licKeyToken=31bf3856ad364e35")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                " PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                "tral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                "l, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.PersistentParameters, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.ConfigFileState, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral" +
                                ", PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.FileFetchInformation, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                "utral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                "yToken=31bf3856ad364e35")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Info, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Passive, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral" +
                                ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                "")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, Publi" +
                                "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutr" +
                                "al, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                                "3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Double, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publi" +
                                "cKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                "50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 242, // 0xf2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.LevelTip, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 258, // 0x102
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.RankedStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 274, // 0x112
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 290, // 0x122
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 433, // 0x1b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BasicData, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 449, // 0x1c1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Gold, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 465, // 0x1d1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 306, // 0x132
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 481, // 0x1e1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 481, // 0x1e1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 497, // 0x1f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 497, // 0x1f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.MetaData, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 513, // 0x201
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BasicDataStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 529, // 0x211
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 322, // 0x142
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 545, // 0x221
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 545, // 0x221
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 561, // 0x231
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 577, // 0x241
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 577, // 0x241
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 338, // 0x152
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 593, // 0x251
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 354, // 0x162
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 609, // 0x261
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 625, // 0x271
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.League, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 641, // 0x281
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 370, // 0x172
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.MatchList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 657, // 0x291
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, Publi" +
                                "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 386, // 0x182
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 673, // 0x2a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 402, // 0x192
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 689, // 0x2b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.RawStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 705, // 0x2c1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 721, // 0x2d1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 737, // 0x2e1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 418, // 0x1a2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 753, // 0x2f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 753, // 0x2f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 769, // 0x301
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 769, // 0x301
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 434, // 0x1b2
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContracts_Hashtable = new byte[0];
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_classDataContracts_Hashtable = new byte[0];
        // Count=49
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // AdMediatorConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 255, // AdMediatorConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 255, // AdMediatorConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdMediatorConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdMediatorConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadAdMediatorConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteAdMediatorConfigurationToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 15,
                    MemberNamesListIndex = 17,
                    MemberNamespacesListIndex = 31,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 280, // BaseConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 280, // BaseConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 280, // BaseConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.BaseConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.BaseConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type2.ReadBaseConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type3.WriteBaseConfigurationToXml),
                    ChildElementNamespacesListIndex = 45,
                    ContractNamespacesListIndex = 52,
                    MemberNamesListIndex = 54,
                    MemberNamespacesListIndex = 61,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 319, // AdAdapterInfo
                        NamespaceIndex = 279, // 
                        StableNameIndex = 319, // AdAdapterInfo
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 319, // AdAdapterInfo
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                    "licKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type7.ReadAdAdapterInfoFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type8.WriteAdAdapterInfoToXml),
                    ChildElementNamespacesListIndex = 68,
                    ContractNamespacesListIndex = 74,
                    MemberNamesListIndex = 76,
                    MemberNamespacesListIndex = 82,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 349, // Property
                        NamespaceIndex = 279, // 
                        StableNameIndex = 349, // Property
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 349, // Property
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                    " PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WritePropertyToXml),
                    ChildElementNamespacesListIndex = 88,
                    ContractNamespacesListIndex = 91,
                    MemberNamesListIndex = 93,
                    MemberNamespacesListIndex = 96,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 388, // AdControlConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 388, // AdControlConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 388, // AdControlConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                    "tral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                    "tral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type17.ReadAdControlConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type18.WriteAdControlConfigurationToXml),
                    ChildElementNamespacesListIndex = 99,
                    ContractNamespacesListIndex = 103,
                    MemberNamesListIndex = 105,
                    MemberNamespacesListIndex = 109,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 438, // MarketConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 438, // MarketConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 438, // MarketConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                    "l, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                    "l, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type22.ReadMarketConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type23.WriteMarketConfigurationToXml),
                    ChildElementNamespacesListIndex = 113,
                    ContractNamespacesListIndex = 121,
                    MemberNamesListIndex = 124,
                    MemberNamespacesListIndex = 132,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 458, // PersistentParameters
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        StableNameIndex = 458, // PersistentParameters
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        TopLevelElementNameIndex = 458, // PersistentParameters
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.PersistentParameters, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.PersistentParameters, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type24.ReadPersistentParametersFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type25.WritePersistentParametersToXml),
                    ChildElementNamespacesListIndex = 140,
                    ContractNamespacesListIndex = 143,
                    MemberNamesListIndex = 145,
                    MemberNamespacesListIndex = 148,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 555, // ConfigFileState
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        StableNameIndex = 555, // ConfigFileState
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        TopLevelElementNameIndex = 555, // ConfigFileState
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.ConfigFileState, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral" +
                                    ", PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.ConfigFileState, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral" +
                                    ", PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type26.ReadConfigFileStateFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type27.WriteConfigFileStateToXml),
                    ChildElementNamespacesListIndex = 151,
                    ContractNamespacesListIndex = 155,
                    MemberNamesListIndex = 157,
                    MemberNamespacesListIndex = 161,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 571, // FileFetchInformation
                        NamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        StableNameIndex = 571, // FileFetchInformation
                        StableNameNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        TopLevelElementNameIndex = 571, // FileFetchInformation
                        TopLevelElementNamespaceIndex = 479, // http://schemas.datacontract.org/2004/07/Microsoft.AdMediator.Core.Utilities
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.FileFetchInformation, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Utilities.FileFetchInformation, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=ne" +
                                    "utral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type28.ReadFileFetchInformationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type29.WriteFileFetchInformationToXml),
                    ChildElementNamespacesListIndex = 165,
                    ContractNamespacesListIndex = 169,
                    MemberNamesListIndex = 171,
                    MemberNamespacesListIndex = 175,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 608, // SdkError
                        NamespaceIndex = 279, // 
                        StableNameIndex = 608, // SdkError
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 608, // SdkError
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                    "yToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                    "yToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 179,
                    ContractNamespacesListIndex = 183,
                    MemberNamesListIndex = 185,
                    MemberNamespacesListIndex = 189,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 617, // ChampionList
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 617, // ChampionList
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 617, // ChampionList
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 193,
                    ContractNamespacesListIndex = 202,
                    MemberNamesListIndex = 204,
                    MemberNamespacesListIndex = 213,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 705, // Champion
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 705, // Champion
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 705, // Champion
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 222,
                    ContractNamespacesListIndex = 241,
                    MemberNamesListIndex = 243,
                    MemberNamespacesListIndex = 262,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 786, // Image
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 786, // Image
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 786, // Image
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 281,
                    ContractNamespacesListIndex = 290,
                    MemberNamesListIndex = 292,
                    MemberNamespacesListIndex = 301,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 792, // Info
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 792, // Info
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 792, // Info
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Info, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Info, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 310,
                    ContractNamespacesListIndex = 315,
                    MemberNamesListIndex = 317,
                    MemberNamespacesListIndex = 322,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 797, // Passive
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 797, // Passive
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 797, // Passive
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Passive, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Passive, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 327,
                    ContractNamespacesListIndex = 332,
                    MemberNamesListIndex = 334,
                    MemberNamespacesListIndex = 339,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 824, // Recommended
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 824, // Recommended
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 824, // Recommended
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 344,
                    ContractNamespacesListIndex = 352,
                    MemberNamesListIndex = 354,
                    MemberNamespacesListIndex = 362,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 849, // Block
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 849, // Block
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 849, // Block
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 370,
                    ContractNamespacesListIndex = 374,
                    MemberNamesListIndex = 376,
                    MemberNamespacesListIndex = 380,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 872, // BlockItem
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 872, // BlockItem
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 872, // BlockItem
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 384,
                    ContractNamespacesListIndex = 387,
                    MemberNamesListIndex = 389,
                    MemberNamespacesListIndex = 392,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 894, // Skin
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 894, // Skin
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 894, // Skin
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 395,
                    ContractNamespacesListIndex = 399,
                    MemberNamesListIndex = 401,
                    MemberNamespacesListIndex = 405,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 920, // ChampionSpell
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 920, // ChampionSpell
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 920, // ChampionSpell
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 409,
                    ContractNamespacesListIndex = 431,
                    MemberNamesListIndex = 433,
                    MemberNamespacesListIndex = 455,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 987, // LevelTip
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 987, // LevelTip
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 987, // LevelTip
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.LevelTip, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.LevelTip, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 477,
                    ContractNamespacesListIndex = 480,
                    MemberNamesListIndex = 482,
                    MemberNamespacesListIndex = 485,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1013, // SpellVars
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1013, // SpellVars
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1013, // SpellVars
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 488,
                    ContractNamespacesListIndex = 494,
                    MemberNamesListIndex = 496,
                    MemberNamespacesListIndex = 502,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1023, // RankedStats
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1023, // RankedStats
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1023, // RankedStats
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.RankedStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.RankedStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 508,
                    ContractNamespacesListIndex = 562,
                    MemberNamesListIndex = 564,
                    MemberNamespacesListIndex = 618,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1075, // KeyValueOfstringChampion6sVDSevQ
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1075, // KeyValueOfstringChampion6sVDSevQ
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1075, // KeyValueOfstringChampion6sVDSevQ
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 672,
                    ContractNamespacesListIndex = 675,
                    MemberNamesListIndex = 677,
                    MemberNamespacesListIndex = 680,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1118, // KeyValuePairOfstringChampion6sVDSevQ
                        NamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1118, // KeyValuePairOfstringChampion6sVDSevQ
                        StableNameNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1118, // KeyValuePairOfstringChampion6sVDSevQ
                        TopLevelElementNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 683,
                    ContractNamespacesListIndex = 686,
                    MemberNamesListIndex = 688,
                    MemberNamespacesListIndex = 691,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1252, // KeyValueOfstringstring
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1252, // KeyValueOfstringstring
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1252, // KeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 694,
                    ContractNamespacesListIndex = 697,
                    MemberNamesListIndex = 699,
                    MemberNamespacesListIndex = 702,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1275, // KeyValuePairOfstringstring
                        NamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1275, // KeyValuePairOfstringstring
                        StableNameNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1275, // KeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 705,
                    ContractNamespacesListIndex = 708,
                    MemberNamesListIndex = 710,
                    MemberNamespacesListIndex = 713,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1302, // ItemList
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1302, // ItemList
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1302, // ItemList
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 716,
                    ContractNamespacesListIndex = 723,
                    MemberNamesListIndex = 725,
                    MemberNamespacesListIndex = 732,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1311, // BasicData
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1311, // BasicData
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1311, // BasicData
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BasicData, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BasicData, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 739,
                    ContractNamespacesListIndex = 763,
                    MemberNamesListIndex = 765,
                    MemberNamespacesListIndex = 789,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1321, // Gold
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1321, // Gold
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1321, // Gold
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Gold, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Gold, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 813,
                    ContractNamespacesListIndex = 818,
                    MemberNamesListIndex = 820,
                    MemberNamespacesListIndex = 825,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1357, // KeyValueOfstringboolean
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1357, // KeyValueOfstringboolean
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1357, // KeyValueOfstringboolean
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 830,
                    ContractNamespacesListIndex = 833,
                    MemberNamesListIndex = 835,
                    MemberNamespacesListIndex = 838,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1381, // KeyValuePairOfstringboolean
                        NamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1381, // KeyValuePairOfstringboolean
                        StableNameNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1381, // KeyValuePairOfstringboolean
                        TopLevelElementNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 841,
                    ContractNamespacesListIndex = 844,
                    MemberNamesListIndex = 846,
                    MemberNamespacesListIndex = 849,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1409, // MetaData
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1409, // MetaData
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1409, // MetaData
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.MetaData, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.MetaData, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 852,
                    ContractNamespacesListIndex = 856,
                    MemberNamesListIndex = 858,
                    MemberNamespacesListIndex = 862,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1418, // BasicDataStats
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1418, // BasicDataStats
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1418, // BasicDataStats
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BasicDataStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BasicDataStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 866,
                    ContractNamespacesListIndex = 930,
                    MemberNamesListIndex = 932,
                    MemberNamespacesListIndex = 996,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1469, // KeyValueOfstringItem6sVDSevQ
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1469, // KeyValueOfstringItem6sVDSevQ
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1469, // KeyValueOfstringItem6sVDSevQ
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1060,
                    ContractNamespacesListIndex = 1063,
                    MemberNamesListIndex = 1065,
                    MemberNamespacesListIndex = 1068,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1498, // Item
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1498, // Item
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1498, // Item
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1071,
                    ContractNamespacesListIndex = 1096,
                    MemberNamesListIndex = 1098,
                    MemberNamespacesListIndex = 1123,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1503, // KeyValuePairOfstringItem6sVDSevQ
                        NamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1503, // KeyValuePairOfstringItem6sVDSevQ
                        StableNameNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1503, // KeyValuePairOfstringItem6sVDSevQ
                        TopLevelElementNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 1148,
                    ContractNamespacesListIndex = 1151,
                    MemberNamesListIndex = 1153,
                    MemberNamespacesListIndex = 1156,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1549, // Group
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1549, // Group
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1549, // Group
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1159,
                    ContractNamespacesListIndex = 1162,
                    MemberNamesListIndex = 1164,
                    MemberNamespacesListIndex = 1167,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1571, // ItemTree
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1571, // ItemTree
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1571, // ItemTree
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1170,
                    ContractNamespacesListIndex = 1173,
                    MemberNamesListIndex = 1175,
                    MemberNamespacesListIndex = 1178,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1580, // Summoner
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1580, // Summoner
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1580, // Summoner
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1181,
                    ContractNamespacesListIndex = 1198,
                    MemberNamesListIndex = 1200,
                    MemberNamespacesListIndex = 1217,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1589, // League
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1589, // League
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1589, // League
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.League, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.League, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1234,
                    ContractNamespacesListIndex = 1239,
                    MemberNamesListIndex = 1241,
                    MemberNamespacesListIndex = 1246,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1612, // MatchList
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1612, // MatchList
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1612, // MatchList
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.MatchList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.MatchList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1251,
                    ContractNamespacesListIndex = 1254,
                    MemberNamesListIndex = 1256,
                    MemberNamespacesListIndex = 1259,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1634, // Game
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1634, // Game
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1634, // Game
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1262,
                    ContractNamespacesListIndex = 1284,
                    MemberNamesListIndex = 1286,
                    MemberNamespacesListIndex = 1308,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1653, // Player
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1653, // Player
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1653, // Player
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1330,
                    ContractNamespacesListIndex = 1334,
                    MemberNamesListIndex = 1336,
                    MemberNamespacesListIndex = 1340,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1660, // RawStats
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1660, // RawStats
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1660, // RawStats
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.RawStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.RawStats, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1344,
                    ContractNamespacesListIndex = 1431,
                    MemberNamesListIndex = 1433,
                    MemberNamespacesListIndex = 1520,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1669, // SummonerSpell
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1669, // SummonerSpell
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1669, // SummonerSpell
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1607,
                    ContractNamespacesListIndex = 1631,
                    MemberNamesListIndex = 1633,
                    MemberNamespacesListIndex = 1657,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1683, // SpellList
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1683, // SpellList
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1683, // SpellList
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellList, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 1681,
                    ContractNamespacesListIndex = 1685,
                    MemberNamesListIndex = 1687,
                    MemberNamespacesListIndex = 1691,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1738, // KeyValueOfstringSummonerSpell6sVDSevQ
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1738, // KeyValueOfstringSummonerSpell6sVDSevQ
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1738, // KeyValueOfstringSummonerSpell6sVDSevQ
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1695,
                    ContractNamespacesListIndex = 1698,
                    MemberNamesListIndex = 1700,
                    MemberNamespacesListIndex = 1703,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1776, // KeyValuePairOfstringSummonerSpell6sVDSevQ
                        NamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1776, // KeyValuePairOfstringSummonerSpell6sVDSevQ
                        StableNameNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1776, // KeyValuePairOfstringSummonerSpell6sVDSevQ
                        TopLevelElementNamespaceIndex = 1155, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 1706,
                    ContractNamespacesListIndex = 1709,
                    MemberNamesListIndex = 1711,
                    MemberNamespacesListIndex = 1714,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_collectionDataContracts_Hashtable = new byte[0];
        // Count=28
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 298, // ArrayOfAdAdapterInfo
                        NamespaceIndex = 279, // 
                        StableNameIndex = 298, // ArrayOfAdAdapterInfo
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 298, // ArrayOfAdAdapterInfo
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type4.ReadArrayOfAdAdapterInfoFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type5.WriteArrayOfAdAdapterInfoToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type6.ReadArrayOfAdAdapterInfoFromXmlIsGetOnly),
                    CollectionItemNameIndex = 319, // AdAdapterInfo
                    KeyNameIndex = -1,
                    ItemNameIndex = 319, // AdAdapterInfo
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterInfo, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, Pub" +
                                "licKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 333, // ArrayOfProperty
                        NamespaceIndex = 279, // 
                        StableNameIndex = 333, // ArrayOfProperty
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 333, // ArrayOfProperty
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type9.ReadArrayOfPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type10.WriteArrayOfPropertyToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type11.ReadArrayOfPropertyFromXmlIsGetOnly),
                    CollectionItemNameIndex = 349, // Property
                    KeyNameIndex = -1,
                    ItemNameIndex = 349, // Property
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdAdapterProperty, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral," +
                                " PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 358, // ArrayOfAdControlConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 358, // ArrayOfAdControlConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 358, // ArrayOfAdControlConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type14.ReadArrayOfAdControlConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type15.WriteArrayOfAdControlConfigurationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type16.ReadArrayOfAdControlConfigurationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 388, // AdControlConfiguration
                    KeyNameIndex = -1,
                    ItemNameIndex = 388, // AdControlConfiguration
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.AdControlConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neu" +
                                "tral, PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 411, // ArrayOfMarketConfiguration
                        NamespaceIndex = 279, // 
                        StableNameIndex = 411, // ArrayOfMarketConfiguration
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 411, // ArrayOfMarketConfiguration
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type19.ReadArrayOfMarketConfigurationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type20.WriteArrayOfMarketConfigurationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type21.ReadArrayOfMarketConfigurationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 438, // MarketConfiguration
                    KeyNameIndex = -1,
                    ItemNameIndex = 438, // MarketConfiguration
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Models.MarketConfiguration, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutra" +
                                "l, PublicKeyToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 592, // ArrayOfSdkError
                        NamespaceIndex = 279, // 
                        StableNameIndex = 592, // ArrayOfSdkError
                        StableNameNamespaceIndex = 279, // 
                        TopLevelElementNameIndex = 592, // ArrayOfSdkError
                        TopLevelElementNamespaceIndex = 279, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 608, // SdkError
                    KeyNameIndex = -1,
                    ItemNameIndex = 608, // SdkError
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.AdMediator.Core.Events.SdkError, Microsoft.AdMediator.Core, Version=2.0.1.0, Culture=neutral, PublicKe" +
                                "yToken=31bf3856ad364e35")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 689, // ArrayOfChampion
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 689, // ArrayOfChampion
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 689, // ArrayOfChampion
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 705, // Champion
                    KeyNameIndex = -1,
                    ItemNameIndex = 705, // Champion
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 714, // ArrayOfstring
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 714, // ArrayOfstring
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 714, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 805, // ArrayOfRecommended
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 805, // ArrayOfRecommended
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 805, // ArrayOfRecommended
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral" +
                                    ", PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 824, // Recommended
                    KeyNameIndex = -1,
                    ItemNameIndex = 824, // Recommended
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Recommended, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 836, // ArrayOfBlock
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 836, // ArrayOfBlock
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 836, // ArrayOfBlock
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 849, // Block
                    KeyNameIndex = -1,
                    ItemNameIndex = 849, // Block
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Block, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 855, // ArrayOfBlockItem
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 855, // ArrayOfBlockItem
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 855, // ArrayOfBlockItem
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 872, // BlockItem
                    KeyNameIndex = -1,
                    ItemNameIndex = 872, // BlockItem
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.BlockItem, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 882, // ArrayOfSkin
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 882, // ArrayOfSkin
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 882, // ArrayOfSkin
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 894, // Skin
                    KeyNameIndex = -1,
                    ItemNameIndex = 894, // Skin
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Skin, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 899, // ArrayOfChampionSpell
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 899, // ArrayOfChampionSpell
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 899, // ArrayOfChampionSpell
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                                    "3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a" +
                                    "3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 920, // ChampionSpell
                    KeyNameIndex = -1,
                    ItemNameIndex = 920, // ChampionSpell
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ChampionSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 934, // ArrayOfImage
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 934, // ArrayOfImage
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 934, // ArrayOfImage
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 786, // Image
                    KeyNameIndex = -1,
                    ItemNameIndex = 786, // Image
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Image, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 947, // ArrayOfdouble
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 947, // ArrayOfdouble
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 947, // ArrayOfdouble
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Double, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Double, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 128, // double
                    KeyNameIndex = -1,
                    ItemNameIndex = 128, // double
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 961, // ArrayOfint
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 961, // ArrayOfint
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 961, // ArrayOfint
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Int32, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 146, // int
                    KeyNameIndex = -1,
                    ItemNameIndex = 146, // int
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 972, // ArrayOfanyType
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 972, // ArrayOfanyType
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 972, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 996, // ArrayOfSpellVars
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 996, // ArrayOfSpellVars
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 996, // ArrayOfSpellVars
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1013, // SpellVars
                    KeyNameIndex = -1,
                    ItemNameIndex = 1013, // SpellVars
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.SpellVars, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1035, // ArrayOfKeyValueOfstringChampion6sVDSevQ
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1035, // ArrayOfKeyValueOfstringChampion6sVDSevQ
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1035, // ArrayOfKeyValueOfstringChampion6sVDSevQ
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1075, // KeyValueOfstringChampion6sVDSevQ
                    KeyNameIndex = 1108, // Key
                    ItemNameIndex = 1075, // KeyValueOfstringChampion6sVDSevQ
                    ValueNameIndex = 1112, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Champion, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1222, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1222, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1222, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1252, // KeyValueOfstringstring
                    KeyNameIndex = 1108, // Key
                    ItemNameIndex = 1252, // KeyValueOfstringstring
                    ValueNameIndex = 1112, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1326, // ArrayOfKeyValueOfstringboolean
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1326, // ArrayOfKeyValueOfstringboolean
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1326, // ArrayOfKeyValueOfstringboolean
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1357, // KeyValueOfstringboolean
                    KeyNameIndex = 1108, // Key
                    ItemNameIndex = 1357, // KeyValueOfstringboolean
                    ValueNameIndex = 1112, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Boolean, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1433, // ArrayOfKeyValueOfstringItem6sVDSevQ
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1433, // ArrayOfKeyValueOfstringItem6sVDSevQ
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1433, // ArrayOfKeyValueOfstringItem6sVDSevQ
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1469, // KeyValueOfstringItem6sVDSevQ
                    KeyNameIndex = 1108, // Key
                    ItemNameIndex = 1469, // KeyValueOfstringItem6sVDSevQ
                    ValueNameIndex = 1112, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.Item, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1536, // ArrayOfGroup
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1536, // ArrayOfGroup
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1536, // ArrayOfGroup
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1549, // Group
                    KeyNameIndex = -1,
                    ItemNameIndex = 1549, // Group
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Group, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1555, // ArrayOfItemTree
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1555, // ArrayOfItemTree
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1555, // ArrayOfItemTree
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1571, // ItemTree
                    KeyNameIndex = -1,
                    ItemNameIndex = 1571, // ItemTree
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.ItemTree, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1596, // ArrayOfSummoner
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1596, // ArrayOfSummoner
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1596, // ArrayOfSummoner
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, P" +
                                    "ublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1580, // Summoner
                    KeyNameIndex = -1,
                    ItemNameIndex = 1580, // Summoner
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Summoner, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1622, // ArrayOfGame
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1622, // ArrayOfGame
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1622, // ArrayOfGame
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, Publi" +
                                    "cKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1634, // Game
                    KeyNameIndex = -1,
                    ItemNameIndex = 1634, // Game
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Game, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1639, // ArrayOfPlayer
                        NamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        StableNameIndex = 1639, // ArrayOfPlayer
                        StableNameNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        TopLevelElementNameIndex = 1639, // ArrayOfPlayer
                        TopLevelElementNamespaceIndex = 630, // http://schemas.datacontract.org/2004/07/Well_Played.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1653, // Player
                    KeyNameIndex = -1,
                    ItemNameIndex = 1653, // Player
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Well_Played.Models.Player, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1693, // ArrayOfKeyValueOfstringSummonerSpell6sVDSevQ
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1693, // ArrayOfKeyValueOfstringSummonerSpell6sVDSevQ
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1693, // ArrayOfKeyValueOfstringSummonerSpell6sVDSevQ
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 1738, // KeyValueOfstringSummonerSpell6sVDSevQ
                    KeyNameIndex = 1108, // Key
                    ItemNameIndex = 1738, // KeyValueOfstringSummonerSpell6sVDSevQ
                    ValueNameIndex = 1112, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[Well_Played.Models.SummonerSpell, Well Played, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Private.DataContractSerialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 972, // ArrayOfanyType
                        NamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 972, // ArrayOfanyType
                        StableNameNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 972, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 728, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_enumDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_xmlDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_jsonDelegatesList_Hashtable = new byte[0];
        // Count=64
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type33.WriteArrayOfSdkErrorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type32.ReadArrayOfSdkErrorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type37.WriteSdkErrorToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type36.ReadSdkErrorFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type41.WriteChampionListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type40.ReadChampionListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type46.WriteArrayOfChampionToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type45.ReadArrayOfChampionFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type47.ReadArrayOfChampionFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type51.WriteChampionToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type50.ReadChampionFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type56.WriteArrayOfstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type55.ReadArrayOfstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type57.ReadArrayOfstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type61.WriteImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type60.ReadImageFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type65.WriteInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type64.ReadInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type69.WritePassiveToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type68.ReadPassiveFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type74.WriteArrayOfRecommendedToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type73.ReadArrayOfRecommendedFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type75.ReadArrayOfRecommendedFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type79.WriteRecommendedToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type78.ReadRecommendedFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type84.WriteArrayOfBlockToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type83.ReadArrayOfBlockFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type85.ReadArrayOfBlockFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type89.WriteBlockToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type88.ReadBlockFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type94.WriteArrayOfBlockItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type93.ReadArrayOfBlockItemFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type95.ReadArrayOfBlockItemFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type99.WriteBlockItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type98.ReadBlockItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type104.WriteArrayOfSkinToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type103.ReadArrayOfSkinFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type105.ReadArrayOfSkinFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type109.WriteSkinToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type108.ReadSkinFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type114.WriteArrayOfChampionSpellToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type113.ReadArrayOfChampionSpellFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type115.ReadArrayOfChampionSpellFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type119.WriteChampionSpellToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type118.ReadChampionSpellFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type124.WriteArrayOfImageToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type123.ReadArrayOfImageFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type125.ReadArrayOfImageFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type130.WriteArrayOfdoubleToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type129.ReadArrayOfdoubleFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type131.ReadArrayOfdoubleFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 71,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type136.WriteArrayOfintToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type135.ReadArrayOfintFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type137.ReadArrayOfintFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 72,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type142.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type141.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type143.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 73,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type147.WriteLevelTipToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type146.ReadLevelTipFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 74,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type152.WriteArrayOfSpellVarsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type151.ReadArrayOfSpellVarsFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type153.ReadArrayOfSpellVarsFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 75,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type157.WriteSpellVarsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type156.ReadSpellVarsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 76,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type161.WriteRankedStatsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type160.ReadRankedStatsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 77,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type166.WriteArrayOfKeyValueOfstringChampion6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type165.ReadArrayOfKeyValueOfstringChampion6sVDSevQFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type167.ReadArrayOfKeyValueOfstringChampion6sVDSevQFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 78,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type171.WriteKeyValueOfstringChampion6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type170.ReadKeyValueOfstringChampion6sVDSevQFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 80,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type175.WriteKeyValuePairOfstringChampion6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type174.ReadKeyValuePairOfstringChampion6sVDSevQFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 82,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type180.WriteArrayOfKeyValueOfstringstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type179.ReadArrayOfKeyValueOfstringstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type181.ReadArrayOfKeyValueOfstringstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 83,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type185.WriteKeyValueOfstringstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type184.ReadKeyValueOfstringstringFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 85,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type189.WriteKeyValuePairOfstringstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type188.ReadKeyValuePairOfstringstringFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 87,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type193.WriteItemListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type192.ReadItemListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 88,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type197.WriteBasicDataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type196.ReadBasicDataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 89,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type201.WriteGoldToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type200.ReadGoldFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 90,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type206.WriteArrayOfKeyValueOfstringbooleanToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type205.ReadArrayOfKeyValueOfstringbooleanFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type207.ReadArrayOfKeyValueOfstringbooleanFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 91,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type211.WriteKeyValueOfstringbooleanToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type210.ReadKeyValueOfstringbooleanFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 93,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type215.WriteKeyValuePairOfstringbooleanToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type214.ReadKeyValuePairOfstringbooleanFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 95,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type219.WriteMetaDataToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type218.ReadMetaDataFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 96,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type223.WriteBasicDataStatsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type222.ReadBasicDataStatsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 97,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type228.WriteArrayOfKeyValueOfstringItem6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type227.ReadArrayOfKeyValueOfstringItem6sVDSevQFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type229.ReadArrayOfKeyValueOfstringItem6sVDSevQFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 98,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type233.WriteKeyValueOfstringItem6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type232.ReadKeyValueOfstringItem6sVDSevQFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 100,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type237.WriteItemToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type236.ReadItemFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 101,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type241.WriteKeyValuePairOfstringItem6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type240.ReadKeyValuePairOfstringItem6sVDSevQFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 103,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type246.WriteArrayOfGroupToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type245.ReadArrayOfGroupFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type247.ReadArrayOfGroupFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 104,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type251.WriteGroupToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type250.ReadGroupFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 105,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type256.WriteArrayOfItemTreeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type255.ReadArrayOfItemTreeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type257.ReadArrayOfItemTreeFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 106,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type261.WriteItemTreeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type260.ReadItemTreeFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 107,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type265.WriteSummonerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type264.ReadSummonerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 108,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type269.WriteLeagueToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type268.ReadLeagueFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 109,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type274.WriteArrayOfSummonerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type273.ReadArrayOfSummonerFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type275.ReadArrayOfSummonerFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 110,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type279.WriteMatchListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type278.ReadMatchListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 111,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type284.WriteArrayOfGameToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type283.ReadArrayOfGameFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type285.ReadArrayOfGameFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 112,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type289.WriteGameToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type288.ReadGameFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 113,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type294.WriteArrayOfPlayerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type293.ReadArrayOfPlayerFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type295.ReadArrayOfPlayerFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 114,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type299.WritePlayerToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type298.ReadPlayerFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 115,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type303.WriteRawStatsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type302.ReadRawStatsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 116,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type307.WriteSummonerSpellToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type306.ReadSummonerSpellFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 117,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type311.WriteSpellListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type310.ReadSpellListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 118,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type316.WriteArrayOfKeyValueOfstringSummonerSpell6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type315.ReadArrayOfKeyValueOfstringSummonerSpell6sVDSevQFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type317.ReadArrayOfKeyValueOfstringSummonerSpell6sVDSevQFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 119,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type321.WriteKeyValueOfstringSummonerSpell6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type320.ReadKeyValueOfstringSummonerSpell6sVDSevQFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 121,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type325.WriteKeyValuePairOfstringSummonerSpell6sVDSevQToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type324.ReadKeyValuePairOfstringSummonerSpell6sVDSevQFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 123,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type330.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type329.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type331.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','d','M','e','d','i','a','t','o','r','C','o','n','f','i',
            'g','u','r','a','t','i','o','n','\0','\0','B','a','s','e','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','A','r',
            'r','a','y','O','f','A','d','A','d','a','p','t','e','r','I','n','f','o','\0','A','d','A','d','a','p','t','e','r','I','n',
            'f','o','\0','A','r','r','a','y','O','f','P','r','o','p','e','r','t','y','\0','P','r','o','p','e','r','t','y','\0','A','r',
            'r','a','y','O','f','A','d','C','o','n','t','r','o','l','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','A','d',
            'C','o','n','t','r','o','l','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','A','r','r','a','y','O','f','M','a',
            'r','k','e','t','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','M','a','r','k','e','t','C','o','n','f','i','g',
            'u','r','a','t','i','o','n','\0','P','e','r','s','i','s','t','e','n','t','P','a','r','a','m','e','t','e','r','s','\0','h',
            't','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g',
            '/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','A','d','M','e','d','i','a','t','o','r','.',
            'C','o','r','e','.','U','t','i','l','i','t','i','e','s','\0','C','o','n','f','i','g','F','i','l','e','S','t','a','t','e',
            '\0','F','i','l','e','F','e','t','c','h','I','n','f','o','r','m','a','t','i','o','n','\0','A','r','r','a','y','O','f','S',
            'd','k','E','r','r','o','r','\0','S','d','k','E','r','r','o','r','\0','C','h','a','m','p','i','o','n','L','i','s','t','\0',
            'h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r',
            'g','/','2','0','0','4','/','0','7','/','W','e','l','l','_','P','l','a','y','e','d','.','M','o','d','e','l','s','\0','A',
            'r','r','a','y','O','f','C','h','a','m','p','i','o','n','\0','C','h','a','m','p','i','o','n','\0','A','r','r','a','y','O',
            'f','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o',
            'f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A',
            'r','r','a','y','s','\0','I','m','a','g','e','\0','I','n','f','o','\0','P','a','s','s','i','v','e','\0','A','r','r','a','y',
            'O','f','R','e','c','o','m','m','e','n','d','e','d','\0','R','e','c','o','m','m','e','n','d','e','d','\0','A','r','r','a',
            'y','O','f','B','l','o','c','k','\0','B','l','o','c','k','\0','A','r','r','a','y','O','f','B','l','o','c','k','I','t','e',
            'm','\0','B','l','o','c','k','I','t','e','m','\0','A','r','r','a','y','O','f','S','k','i','n','\0','S','k','i','n','\0','A',
            'r','r','a','y','O','f','C','h','a','m','p','i','o','n','S','p','e','l','l','\0','C','h','a','m','p','i','o','n','S','p',
            'e','l','l','\0','A','r','r','a','y','O','f','I','m','a','g','e','\0','A','r','r','a','y','O','f','d','o','u','b','l','e',
            '\0','A','r','r','a','y','O','f','i','n','t','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e','\0','L','e','v',
            'e','l','T','i','p','\0','A','r','r','a','y','O','f','S','p','e','l','l','V','a','r','s','\0','S','p','e','l','l','V','a',
            'r','s','\0','R','a','n','k','e','d','S','t','a','t','s','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e',
            'O','f','s','t','r','i','n','g','C','h','a','m','p','i','o','n','6','s','V','D','S','e','v','Q','\0','K','e','y','V','a',
            'l','u','e','O','f','s','t','r','i','n','g','C','h','a','m','p','i','o','n','6','s','V','D','S','e','v','Q','\0','K','e',
            'y','\0','V','a','l','u','e','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s','t','r','i','n','g','C','h',
            'a','m','p','i','o','n','6','s','V','D','S','e','v','Q','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.',
            'd','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e',
            'm','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n','e','r','i','c','\0','A','r','r','a','y','O','f','K',
            'e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e',
            'O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s',
            't','r','i','n','g','s','t','r','i','n','g','\0','I','t','e','m','L','i','s','t','\0','B','a','s','i','c','D','a','t','a',
            '\0','G','o','l','d','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','b',
            'o','o','l','e','a','n','\0','K','e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','b','o','o','l','e','a','n',
            '\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s','t','r','i','n','g','b','o','o','l','e','a','n','\0','M',
            'e','t','a','D','a','t','a','\0','B','a','s','i','c','D','a','t','a','S','t','a','t','s','\0','A','r','r','a','y','O','f',
            'K','e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','I','t','e','m','6','s','V','D','S','e','v','Q','\0','K',
            'e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','I','t','e','m','6','s','V','D','S','e','v','Q','\0','I','t',
            'e','m','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s','t','r','i','n','g','I','t','e','m','6','s','V',
            'D','S','e','v','Q','\0','A','r','r','a','y','O','f','G','r','o','u','p','\0','G','r','o','u','p','\0','A','r','r','a','y',
            'O','f','I','t','e','m','T','r','e','e','\0','I','t','e','m','T','r','e','e','\0','S','u','m','m','o','n','e','r','\0','L',
            'e','a','g','u','e','\0','A','r','r','a','y','O','f','S','u','m','m','o','n','e','r','\0','M','a','t','c','h','L','i','s',
            't','\0','A','r','r','a','y','O','f','G','a','m','e','\0','G','a','m','e','\0','A','r','r','a','y','O','f','P','l','a','y',
            'e','r','\0','P','l','a','y','e','r','\0','R','a','w','S','t','a','t','s','\0','S','u','m','m','o','n','e','r','S','p','e',
            'l','l','\0','S','p','e','l','l','L','i','s','t','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','O','f',
            's','t','r','i','n','g','S','u','m','m','o','n','e','r','S','p','e','l','l','6','s','V','D','S','e','v','Q','\0','K','e',
            'y','V','a','l','u','e','O','f','s','t','r','i','n','g','S','u','m','m','o','n','e','r','S','p','e','l','l','6','s','V',
            'D','S','e','v','Q','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s','t','r','i','n','g','S','u','m','m',
            'o','n','e','r','S','p','e','l','l','6','s','V','D','S','e','v','Q','\0','A','p','p','V','e','r','s','i','o','n','\0','C',
            'd','n','U','r','i','F','o','r','m','a','t','\0','C','o','n','f','i','g','I','d','\0','F','i','l','e','V','e','r','s','i',
            'o','n','\0','L','e','g','a','c','y','C','o','n','f','i','g','I','d','\0','M','a','r','k','e','t','O','v','e','r','r','i',
            'd','e','s','\0','R','e','f','r','e','s','h','R','a','t','e','\0','S','c','h','e','m','a','V','e','r','s','i','o','n','\0',
            'T','e','s','t','C','o','n','f','i','g','u','r','a','t','i','o','n','\0','U','p','d','a','t','e','d','D','a','t','e','T',
            'i','m','e','\0','U','s','e','R','o','u','n','d','R','o','b','i','n','\0','V','e','r','s','i','o','n','\0','A','d','A','d',
            'a','p','t','e','r','s','\0','A','d','C','o','n','t','r','o','l','C','o','n','f','i','g','u','r','a','t','i','o','n','s',
            '\0','C','o','n','f','i','g','u','r','a','t','i','o','n','U','r','i','\0','R','o','t','a','t','i','o','n','A','l','g','o',
            'r','i','t','h','m','\0','U','n','u','s','e','d','A','d','A','d','a','p','t','e','r','s','\0','M','e','t','a','d','a','t',
            'a','\0','N','a','m','e','\0','R','a','n','k','\0','T','i','m','e','o','u','t','\0','W','e','i','g','h','t','\0','I','d','\0',
            'R','e','g','i','o','n','\0','A','d','M','e','d','i','a','t','o','r','D','e','v','i','c','e','I','d','\0','A','c','t','i',
            'v','e','C','o','n','f','i','g','S','t','o','r','a','g','e','F','o','l','d','e','r','\0','L','a','s','t','K','n','o','w',
            'n','G','o','o','d','C','o','n','f','i','g','S','t','o','r','a','g','e','F','o','l','d','e','r','\0','L','a','s','t','A',
            't','t','e','m','p','t','e','d','F','e','t','c','h','\0','L','a','s','t','S','u','c','c','e','s','s','f','u','l','F','e',
            't','c','h','\0','W','a','s','L','a','s','t','A','t','t','e','m','p','t','S','u','c','c','e','s','s','f','u','l','\0','E',
            'r','r','o','r','C','o','d','e','\0','E','r','r','o','r','T','e','x','t','\0','c','h','a','m','p','i','o','n','s','\0','d',
            'a','t','a','\0','f','o','r','m','a','t','\0','k','e','y','s','\0','m','o','d','i','f','y','D','a','t','e','\0','s','u','m',
            'm','o','n','e','r','I','d','\0','t','y','p','e','\0','v','e','r','s','i','o','n','\0','a','l','l','y','t','i','p','s','\0',
            'b','l','u','r','b','\0','e','n','e','m','y','t','i','p','s','\0','i','d','\0','i','m','a','g','e','\0','i','n','f','o','\0',
            'k','e','y','\0','l','o','r','e','\0','n','a','m','e','\0','p','a','r','t','y','p','e','\0','p','a','s','s','i','v','e','\0',
            'r','e','c','o','m','m','e','n','d','e','d','\0','s','k','i','n','s','\0','s','p','e','l','l','s','\0','s','t','a','t','s',
            '\0','t','a','g','s','\0','t','h','u','m','b','n','a','i','l','\0','t','i','t','l','e','\0','f','u','l','l','\0','g','r','o',
            'u','p','\0','h','\0','s','p','r','i','t','e','\0','u','r','l','\0','w','\0','x','\0','y','\0','a','t','t','a','c','k','\0','d',
            'e','f','e','n','s','e','\0','d','i','f','f','i','c','u','l','t','y','\0','m','a','g','i','c','\0','d','e','s','c','r','i',
            'p','t','i','o','n','\0','s','a','n','i','t','i','z','e','d','D','e','s','c','r','i','p','t','i','o','n','\0','b','l','o',
            'c','k','s','\0','c','h','a','m','p','i','o','n','\0','m','a','p','\0','m','o','d','e','\0','p','r','i','o','r','i','t','y',
            '\0','i','t','e','m','s','\0','r','e','c','M','a','t','h','\0','c','o','u','n','t','\0','n','u','m','\0','a','l','t','i','m',
            'a','g','e','s','\0','c','o','o','l','d','o','w','n','\0','c','o','o','l','d','o','w','n','B','u','r','n','\0','c','o','s',
            't','\0','c','o','s','t','B','u','r','n','\0','c','o','s','t','T','y','p','e','\0','e','f','f','e','c','t','\0','e','f','f',
            'e','c','t','B','u','r','n','\0','l','e','v','e','l','t','i','p','\0','m','a','x','r','a','n','k','\0','r','a','n','g','e',
            '\0','r','a','n','g','e','B','u','r','n','\0','r','e','s','o','u','r','c','e','\0','s','a','n','i','t','i','z','e','d','T',
            'o','o','l','t','i','p','\0','t','o','o','l','t','i','p','\0','v','a','r','s','\0','l','a','b','e','l','\0','c','o','e','f',
            'f','\0','d','y','n','\0','l','i','n','k','\0','r','a','n','k','s','W','i','t','h','\0','a','r','m','o','r','\0','a','r','m',
            'o','r','p','e','r','l','e','v','e','l','\0','a','t','t','a','c','k','d','a','m','a','g','e','\0','a','t','t','a','c','k',
            'd','a','m','a','g','e','p','e','r','l','e','v','e','l','\0','a','t','t','a','c','k','r','a','n','g','e','\0','a','t','t',
            'a','c','k','s','p','e','e','d','o','f','f','s','e','t','\0','a','t','t','a','c','k','s','p','e','e','d','p','e','r','l',
            'e','v','e','l','\0','b','o','t','G','a','m','e','s','P','l','a','y','e','d','\0','c','r','i','t','\0','c','r','i','t','p',
            'e','r','l','e','v','e','l','\0','h','p','\0','h','p','p','e','r','l','e','v','e','l','\0','h','p','r','e','g','e','n','\0',
            'h','p','r','e','g','e','n','p','e','r','l','e','v','e','l','\0','k','i','l','l','i','n','g','S','p','r','e','e','\0','m',
            'a','x','C','h','a','m','p','i','o','n','s','K','i','l','l','e','d','\0','m','a','x','L','a','r','g','e','s','t','C','r',
            'i','t','i','c','a','l','S','t','r','i','k','e','\0','m','a','x','L','a','r','g','e','s','t','K','i','l','l','i','n','g',
            'S','p','r','e','e','\0','m','a','x','N','u','m','D','e','a','t','h','s','\0','m','a','x','T','i','m','e','P','l','a','y',
            'e','d','\0','m','a','x','T','i','m','e','S','p','e','n','t','L','i','v','i','n','g','\0','m','o','s','t','C','h','a','m',
            'p','i','o','n','K','i','l','l','s','P','e','r','S','e','s','s','i','o','n','\0','m','o','s','t','S','p','e','l','l','s',
            'C','a','s','t','\0','m','o','v','e','s','p','e','e','d','\0','m','p','\0','m','p','p','e','r','l','e','v','e','l','\0','m',
            'p','r','e','g','e','n','\0','m','p','r','e','g','e','n','p','e','r','l','e','v','e','l','\0','n','o','r','m','a','l','G',
            'a','m','e','s','P','l','a','y','e','d','\0','r','a','n','k','e','d','P','r','e','m','a','d','e','G','a','m','e','s','P',
            'l','a','y','e','d','\0','r','a','n','k','e','d','S','o','l','o','G','a','m','e','s','P','l','a','y','e','d','\0','s','p',
            'e','l','l','b','l','o','c','k','\0','s','p','e','l','l','b','l','o','c','k','p','e','r','l','e','v','e','l','\0','t','o',
            't','a','l','A','s','s','i','s','t','s','\0','t','o','t','a','l','C','h','a','m','p','i','o','n','K','i','l','l','s','\0',
            't','o','t','a','l','D','a','m','a','g','e','D','e','a','l','t','\0','t','o','t','a','l','D','a','m','a','g','e','T','a',
            'k','e','n','\0','t','o','t','a','l','D','e','a','t','h','s','P','e','r','S','e','s','s','i','o','n','\0','t','o','t','a',
            'l','D','o','u','b','l','e','K','i','l','l','s','\0','t','o','t','a','l','F','i','r','s','t','B','l','o','o','d','\0','t',
            'o','t','a','l','G','o','l','d','E','a','r','n','e','d','\0','t','o','t','a','l','H','e','a','l','\0','t','o','t','a','l',
            'M','a','g','i','c','D','a','m','a','g','e','D','e','a','l','t','\0','t','o','t','a','l','M','i','n','i','o','n','K','i',
            'l','l','s','\0','t','o','t','a','l','P','e','n','t','a','K','i','l','l','s','\0','t','o','t','a','l','P','h','y','s','i',
            'c','a','l','D','a','m','a','g','e','D','e','a','l','t','\0','t','o','t','a','l','Q','u','a','d','r','a','K','i','l','l',
            's','\0','t','o','t','a','l','S','e','s','s','i','o','n','s','L','o','s','t','\0','t','o','t','a','l','S','e','s','s','i',
            'o','n','s','P','l','a','y','e','d','\0','t','o','t','a','l','S','e','s','s','i','o','n','s','W','o','n','\0','t','o','t',
            'a','l','T','r','i','p','l','e','K','i','l','l','s','\0','t','o','t','a','l','T','u','r','r','e','t','s','K','i','l','l',
            'e','d','\0','t','o','t','a','l','U','n','r','e','a','l','K','i','l','l','s','\0','v','a','l','u','e','\0','b','a','s','i',
            'c','\0','g','r','o','u','p','s','\0','t','r','e','e','\0','c','o','l','l','o','q','\0','c','o','n','s','u','m','e','O','n',
            'F','u','l','l','\0','c','o','n','s','u','m','e','d','\0','d','e','p','t','h','\0','f','r','o','m','\0','g','o','l','d','\0',
            'h','i','d','e','F','r','o','m','A','l','l','\0','i','n','S','t','o','r','e','\0','m','a','p','s','\0','p','l','a','i','n',
            't','e','x','t','\0','r','e','q','u','i','r','e','d','C','h','a','m','p','i','o','n','\0','r','u','n','e','\0','s','p','e',
            'c','i','a','l','R','e','c','i','p','e','\0','s','t','a','c','k','s','\0','b','a','s','e','G','o','l','d','\0','p','u','r',
            'c','h','a','s','a','b','l','e','\0','s','e','l','l','\0','t','o','t','a','l','\0','i','s','R','u','n','e','\0','t','i','e',
            'r','\0','F','l','a','t','A','r','m','o','r','M','o','d','\0','F','l','a','t','A','t','t','a','c','k','S','p','e','e','d',
            'M','o','d','\0','F','l','a','t','B','l','o','c','k','M','o','d','\0','F','l','a','t','C','r','i','t','C','h','a','n','c',
            'e','M','o','d','\0','F','l','a','t','C','r','i','t','D','a','m','a','g','e','M','o','d','\0','F','l','a','t','E','X','P',
            'B','o','n','u','s','\0','F','l','a','t','E','n','e','r','g','y','P','o','o','l','M','o','d','\0','F','l','a','t','E','n',
            'e','r','g','y','R','e','g','e','n','M','o','d','\0','F','l','a','t','H','P','P','o','o','l','M','o','d','\0','F','l','a',
            't','H','P','R','e','g','e','n','M','o','d','\0','F','l','a','t','M','P','P','o','o','l','M','o','d','\0','F','l','a','t',
            'M','P','R','e','g','e','n','M','o','d','\0','F','l','a','t','M','a','g','i','c','D','a','m','a','g','e','M','o','d','\0',
            'F','l','a','t','M','o','v','e','m','e','n','t','S','p','e','e','d','M','o','d','\0','F','l','a','t','P','h','y','s','i',
            'c','a','l','D','a','m','a','g','e','M','o','d','\0','F','l','a','t','S','p','e','l','l','B','l','o','c','k','M','o','d',
            '\0','P','e','r','c','e','n','t','A','r','m','o','r','M','o','d','\0','P','e','r','c','e','n','t','A','t','t','a','c','k',
            'S','p','e','e','d','M','o','d','\0','P','e','r','c','e','n','t','B','l','o','c','k','M','o','d','\0','P','e','r','c','e',
            'n','t','C','r','i','t','C','h','a','n','c','e','M','o','d','\0','P','e','r','c','e','n','t','C','r','i','t','D','a','m',
            'a','g','e','M','o','d','\0','P','e','r','c','e','n','t','D','o','d','g','e','M','o','d','\0','P','e','r','c','e','n','t',
            'E','X','P','B','o','n','u','s','\0','P','e','r','c','e','n','t','H','P','P','o','o','l','M','o','d','\0','P','e','r','c',
            'e','n','t','H','p','R','e','g','e','n','M','o','d','\0','P','e','r','c','e','n','t','L','i','f','e','S','t','e','a','l',
            'M','o','d','\0','P','e','r','c','e','n','t','M','P','P','o','o','l','\0','P','e','r','c','e','n','t','M','P','R','e','g',
            'e','n','\0','P','e','r','c','e','n','t','M','a','g','i','c','D','a','m','a','g','e','M','o','d','\0','P','e','r','c','e',
            'n','t','M','o','v','e','m','e','n','t','S','p','e','e','d','M','o','d','\0','P','e','r','c','e','n','t','P','h','y','s',
            'i','c','a','l','D','a','m','a','g','e','M','o','d','\0','P','e','r','c','e','n','t','S','p','e','l','l','B','l','o','c',
            'k','M','o','d','\0','P','e','r','c','e','n','t','S','p','e','l','l','V','a','m','p','M','o','d','\0','r','F','l','a','t',
            'A','r','m','o','r','M','o','d','P','e','r','L','e','v','e','l','\0','r','F','l','a','t','A','r','m','o','r','P','e','n',
            'e','t','r','a','t','i','o','n','M','o','d','\0','r','F','l','a','t','A','r','m','o','r','P','e','n','e','t','r','a','t',
            'i','o','n','M','o','d','P','e','r','L','e','v','e','l','\0','r','F','l','a','t','C','r','i','t','C','h','a','n','c','e',
            'M','o','d','P','e','r','L','e','v','e','l','\0','r','F','l','a','t','C','r','i','t','D','a','m','a','g','e','M','o','d',
            'P','e','r','L','e','v','e','l','\0','r','F','l','a','t','D','o','d','g','e','M','o','d','\0','r','F','l','a','t','D','o',
            'd','g','e','M','o','d','P','e','r','L','e','v','e','l','\0','r','F','l','a','t','E','n','e','r','g','y','M','o','d','P',
            'e','r','L','e','v','e','l','\0','r','F','l','a','t','E','n','e','r','g','y','R','e','g','e','n','M','o','d','P','e','r',
            'L','e','v','e','l','\0','r','F','l','a','t','G','o','l','d','P','e','r','1','0','M','o','d','\0','r','F','l','a','t','H',
            'P','M','o','d','P','e','r','L','e','v','e','l','\0','r','F','l','a','t','M','P','R','e','g','e','n','M','o','d','P','e',
            'r','L','e','v','e','l','\0','r','F','l','a','t','M','a','g','i','c','D','a','m','a','g','e','M','o','d','P','e','r','L',
            'e','v','e','l','\0','r','F','l','a','t','M','a','g','i','c','P','e','n','e','t','r','a','t','i','o','n','M','o','d','\0',
            'r','F','l','a','t','M','a','g','i','c','P','e','n','e','t','r','a','t','i','o','n','M','o','d','P','e','r','L','e','v',
            'e','l','\0','r','F','l','a','t','M','o','v','e','m','e','n','t','S','p','e','e','d','M','o','d','P','e','r','L','e','v',
            'e','l','\0','r','F','l','a','t','P','h','y','s','i','c','a','l','D','a','m','a','g','e','M','o','d','P','e','r','L','e',
            'v','e','l','\0','r','F','l','a','t','S','p','e','l','l','B','l','o','c','k','M','o','d','P','e','r','L','e','v','e','l',
            '\0','r','F','l','a','t','T','i','m','e','D','e','a','d','M','o','d','\0','r','F','l','a','t','T','i','m','e','D','e','a',
            'd','M','o','d','P','e','r','L','e','v','e','l','\0','r','P','e','r','c','e','n','t','A','r','m','o','r','P','e','n','e',
            't','r','a','t','i','o','n','M','o','d','\0','r','P','e','r','c','e','n','t','A','r','m','o','r','P','e','n','e','t','r',
            'a','t','i','o','n','M','o','d','P','e','r','L','e','v','e','l','\0','r','P','e','r','c','e','n','t','A','t','t','a','c',
            'k','S','p','e','e','d','M','o','d','P','e','r','L','e','v','e','l','\0','r','P','e','r','c','e','n','t','C','o','o','l',
            'd','o','w','n','M','o','d','\0','r','P','e','r','c','e','n','t','C','o','o','l','d','o','w','n','M','o','d','P','e','r',
            'L','e','v','e','l','\0','r','P','e','r','c','e','n','t','M','a','g','i','c','P','e','n','e','t','r','a','t','i','o','n',
            'M','o','d','\0','r','P','e','r','c','e','n','t','M','a','g','i','c','P','e','n','e','t','r','a','t','i','o','n','M','o',
            'd','P','e','r','L','e','v','e','l','\0','r','P','e','r','c','e','n','t','M','o','v','e','m','e','n','t','S','p','e','e',
            'd','M','o','d','P','e','r','L','e','v','e','l','\0','r','P','e','r','c','e','n','t','T','i','m','e','D','e','a','d','M',
            'o','d','\0','r','P','e','r','c','e','n','t','T','i','m','e','D','e','a','d','M','o','d','P','e','r','L','e','v','e','l',
            '\0','i','m','a','g','e','U','R','L','\0','i','n','t','o','\0','m','a','x','G','r','o','u','p','O','w','n','a','b','l','e',
            '\0','h','e','a','d','e','r','\0','d','i','v','i','s','i','o','n','\0','i','s','F','r','e','s','h','B','l','o','o','d','\0',
            'i','s','H','o','t','S','t','r','e','a','k','\0','i','s','I','n','a','c','t','i','v','e','\0','i','s','V','e','t','e','r',
            'a','n','\0','l','e','a','g','u','e','P','o','i','n','t','s','\0','l','o','s','s','e','s','\0','p','l','a','y','e','r','O',
            'r','T','e','a','m','I','d','\0','p','l','a','y','e','r','O','r','T','e','a','m','N','a','m','e','\0','p','r','o','f','i',
            'l','e','I','c','o','n','I','d','\0','r','e','v','i','s','i','o','n','D','a','t','e','\0','s','u','m','m','o','n','e','r',
            'L','e','v','e','l','\0','w','i','n','s','\0','q','u','e','u','e','\0','s','u','m','m','o','n','e','r','s','\0','g','a','m',
            'e','s','\0','c','h','a','m','p','i','o','n','I','d','\0','c','o','l','o','r','\0','c','r','e','a','t','e','D','a','t','e',
            '\0','f','e','l','l','o','w','P','l','a','y','e','r','s','\0','g','a','m','e','D','a','t','e','\0','g','a','m','e','I','d',
            '\0','g','a','m','e','M','o','d','e','\0','g','a','m','e','T','y','p','e','\0','i','n','v','a','l','i','d','\0','i','p','E',
            'a','r','n','e','d','\0','l','e','v','e','l','\0','m','a','p','I','d','\0','s','p','e','l','l','1','\0','s','p','e','l','l',
            '1','i','m','g','\0','s','p','e','l','l','2','\0','s','p','e','l','l','2','i','m','g','\0','s','u','b','T','y','p','e','\0',
            't','e','a','m','I','d','\0','w','i','n','\0','a','s','s','i','s','t','s','\0','b','a','r','r','a','c','k','s','K','i','l',
            'l','e','d','\0','c','h','a','m','p','i','o','n','s','K','i','l','l','e','d','\0','c','o','m','b','a','t','P','l','a','y',
            'e','r','S','c','o','r','e','\0','c','o','n','s','u','m','a','b','l','e','s','P','u','r','c','h','a','s','e','d','\0','d',
            'a','m','a','g','e','D','e','a','l','t','P','l','a','y','e','r','\0','d','o','u','b','l','e','K','i','l','l','s','\0','f',
            'i','r','s','t','B','l','o','o','d','\0','g','a','m','e','T','i','m','e','\0','g','o','l','d','E','a','r','n','e','d','\0',
            'g','o','l','d','S','p','e','n','d','\0','i','t','e','m','0','\0','i','t','e','m','0','i','m','a','g','e','U','R','L','\0',
            'i','t','e','m','1','\0','i','t','e','m','1','i','m','a','g','e','U','R','L','\0','i','t','e','m','2','\0','i','t','e','m',
            '2','i','m','a','g','e','U','R','L','\0','i','t','e','m','3','\0','i','t','e','m','3','i','m','a','g','e','U','R','L','\0',
            'i','t','e','m','4','\0','i','t','e','m','4','i','m','a','g','e','U','R','L','\0','i','t','e','m','5','\0','i','t','e','m',
            '5','i','m','a','g','e','U','R','L','\0','i','t','e','m','6','\0','i','t','e','m','6','i','m','a','g','e','U','R','L','\0',
            'i','t','e','m','s','P','u','r','c','h','a','s','e','d','\0','k','i','l','l','i','n','g','S','p','r','e','e','s','\0','l',
            'a','r','g','e','s','t','C','r','i','t','i','c','a','l','S','t','r','i','k','e','\0','l','a','r','g','e','s','t','K','i',
            'l','l','i','n','g','S','p','r','e','e','\0','l','a','r','g','e','s','t','M','u','l','t','i','K','i','l','l','\0','l','e',
            'g','e','n','d','a','r','y','I','t','e','m','s','C','r','e','a','t','e','d','\0','m','a','g','i','c','D','a','m','a','g',
            'e','D','e','a','l','t','P','l','a','y','e','r','\0','m','a','g','i','c','D','a','m','a','g','e','D','e','a','l','t','T',
            'o','C','h','a','m','p','i','o','n','s','\0','m','a','g','i','c','D','a','m','a','g','e','T','a','k','e','n','\0','m','i',
            'n','i','o','n','s','D','e','n','i','e','d','\0','m','i','n','i','o','n','s','K','i','l','l','e','d','\0','n','e','u','t',
            'r','a','l','M','i','n','i','o','n','s','K','i','l','l','e','d','\0','n','e','u','t','r','a','l','M','i','n','i','o','n',
            's','K','i','l','l','e','d','E','n','e','m','y','J','u','n','g','l','e','\0','n','e','u','t','r','a','l','M','i','n','i',
            'o','n','s','K','i','l','l','e','d','Y','o','u','r','J','u','n','g','l','e','\0','n','e','x','u','s','K','i','l','l','e',
            'd','\0','n','o','d','e','C','a','p','t','u','r','e','\0','n','o','d','e','C','a','p','t','u','r','e','A','s','s','i','s',
            't','\0','n','o','d','e','N','e','u','t','r','a','l','i','z','e','\0','n','o','d','e','N','e','u','t','r','a','l','i','z',
            'e','A','s','s','i','s','t','\0','n','u','m','D','e','a','t','h','s','\0','n','u','m','I','t','e','m','s','B','o','u','g',
            'h','t','\0','o','b','j','e','c','t','i','v','e','P','l','a','y','e','r','S','c','o','r','e','\0','p','e','n','t','a','K',
            'i','l','l','s','\0','p','h','y','s','i','c','a','l','D','a','m','a','g','e','D','e','a','l','t','P','l','a','y','e','r',
            '\0','p','h','y','s','i','c','a','l','D','a','m','a','g','e','D','e','a','l','t','T','o','C','h','a','m','p','i','o','n',
            's','\0','p','h','y','s','i','c','a','l','D','a','m','a','g','e','T','a','k','e','n','\0','p','l','a','y','e','r','P','o',
            's','i','t','i','o','n','\0','p','l','a','y','e','r','R','o','l','e','\0','q','u','a','d','r','a','K','i','l','l','s','\0',
            's','i','g','h','t','W','a','r','d','s','B','o','u','g','h','t','\0','s','p','e','l','l','1','C','a','s','t','\0','s','p',
            'e','l','l','2','C','a','s','t','\0','s','p','e','l','l','3','C','a','s','t','\0','s','p','e','l','l','4','C','a','s','t',
            '\0','s','u','m','m','o','n','S','p','e','l','l','1','C','a','s','t','\0','s','u','m','m','o','n','S','p','e','l','l','2',
            'C','a','s','t','\0','s','u','p','e','r','M','o','n','s','t','e','r','K','i','l','l','e','d','\0','t','e','a','m','\0','t',
            'e','a','m','O','b','j','e','c','t','i','v','e','\0','t','i','m','e','P','l','a','y','e','d','\0','t','o','t','a','l','D',
            'a','m','a','g','e','D','e','a','l','t','T','o','C','h','a','m','p','i','o','n','s','\0','t','o','t','a','l','P','l','a',
            'y','e','r','S','c','o','r','e','\0','t','o','t','a','l','S','c','o','r','e','R','a','n','k','\0','t','o','t','a','l','T',
            'i','m','e','C','r','o','w','d','C','o','n','t','r','o','l','D','e','a','l','t','\0','t','o','t','a','l','U','n','i','t',
            's','H','e','a','l','e','d','\0','t','r','i','p','l','e','K','i','l','l','s','\0','t','r','u','e','D','a','m','a','g','e',
            'D','e','a','l','t','P','l','a','y','e','r','\0','t','r','u','e','D','a','m','a','g','e','D','e','a','l','t','T','o','C',
            'h','a','m','p','i','o','n','s','\0','t','r','u','e','D','a','m','a','g','e','T','a','k','e','n','\0','t','u','r','r','e',
            't','s','K','i','l','l','e','d','\0','u','n','r','e','a','l','K','i','l','l','s','\0','v','i','c','t','o','r','y','P','o',
            'i','n','t','T','o','t','a','l','\0','v','i','s','i','o','n','W','a','r','d','s','B','o','u','g','h','t','\0','w','a','r',
            'd','K','i','l','l','e','d','\0','w','a','r','d','P','l','a','c','e','d','\0','m','o','d','e','s','\0'};
    }
}
