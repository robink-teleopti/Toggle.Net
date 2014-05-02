﻿using System.Collections.Generic;
using Toggle.Net.Internal;

namespace Toggle.Net.Providers.TextFile
{
	public class FileProvider : IFeatureProvider
	{
		private readonly IDictionary<string, Feature> _features;

		public FileProvider(IDictionary<string, Feature> features)
		{
			_features = features;
		}

		public Feature Get(string flagName)
		{
			Feature feature;
			return _features.TryGetValue(flagName, out feature) ?
					feature :
					null;
		}
	}
}