using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace HnpwaBlazor.Shared.Services
{
	public class Cache
	{
		public bool HasLoaded { get; set; }

		private Dictionary<string, object> Items { get; set; } = new Dictionary<string, object>();
		private readonly IJSRuntime jsRuntime;
		private bool IsRunningOnServer => jsRuntime.GetType().Name == "UnsupportedJavaScriptRuntime";

		public Cache(IJSRuntime js)
		{
			jsRuntime = js ?? throw new ArgumentNullException(nameof(js));
		}

		public async Task<TResult> GetOrAdd<TResult>(string key, Func<Task<TResult>> call)
		{
			if (IsRunningOnServer)
			{
				var res = await call();
				Items[key] = res;
				return res;
			}
			else
			{
				if(!HasLoaded)
				{
					Items = await jsRuntime.InvokeAsync<Dictionary<string, object>>("Cache.load");
					HasLoaded = true;
				}
				if (Items.Remove(key, out var item))
				{
					var json = JsonSerializer.Serialize(item);
					return JsonSerializer.Deserialize<TResult>(json);
				}
				return await call();
			}
		}

		public string Write() => JsonSerializer.Serialize(Items);
	}
}