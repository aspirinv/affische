<script lang="ts">
	import { onMount } from "svelte";
	import { get } from "../../tools/utils";
	import { date } from "../../tools/formatting";

	let links: ShortLinkInfo[] = [];
	onMount(async () => {
		const settings = (await get<Settings>(`/api/Settings`));
		const pref = settings?.functionsPath
			? (settings?.functionsPath + "api/srt/")
			: (location.origin + "/sl/");
		links = (await get<ShortLinkInfo[]>(`/api/ShortLinks`)) ?? [];
		const max = Math.max(...links.map((l) => l.visitsAmount));
		links.forEach((l) => {
			l.progress = 100 * (l.visitsAmount / max);
			l.shortLink = `${pref}${l.code}`;
			l.copied = -1;
		});
	});

	function share(item: ShortLinkInfo){
		if('share' in navigator)
			navigator.share({title: item.title, url: item.shortLink }); 
		else{
			var copyText = document.createElement("input");
			copyText.style.visibility = 'collapse';
			document.body.appendChild(copyText);
			copyText.value = item.shortLink;
			copyText.select();
			copyText.setSelectionRange(0, 99999); // For mobile devices
			navigator.clipboard.writeText(copyText.value);
			document.body.removeChild(copyText);
		}
	}

	interface Settings {
		functionsPath: string;
	}
	interface ShortLinkInfo {
		id: string;
		code: string;
		title: string;
		validTo: Date;
		url: string;
		visitsAmount: number;
		progress?: number;
		shortLink?: string;
		copied:number;
	}
	//https://boxicons.com/?query=plus
</script>

<div class="border p-2">
	<div class="d-flex justify-content-between">
		<h2 class="mb-4">Links</h2>
		<div>
			<a class="btn btn-primary d-flex gap-2" href="/cp/short-link">
				<box-icon name="plus-circle" color="#ffffff"></box-icon>
				<span class="">ADD</span>
			</a>
		</div>
	</div>
	<div class="" style="overflow-y: scroll; height: calc(100vh - 300px);">
		{#each links as item}
			<div class="card mb-2">
				<div class="card-header d-flex justify-content-between bg-primary">
					<h4>
						<span class="text-light text-truncate text-wrap">{item.title}</span>
					</h4>
					<div class="btn-group">
						{#if item.copied === 1}
						<button class="btn btn-outline-light" disabled >Copied</button>
						{/if}
						<button class="btn btn-secondary btn-sm d-flex gap-2" on:click={() => { item.copied = 1; share(item); setTimeout(()=>item.copied = 0, 2000);}}>
							<box-icon name="share-alt" color="#ffffff"></box-icon>
							<span class="">SHARE/COPY</span>
						</button>
					</div>
				</div>
				<div class="card-body">
					<div class=""><a href='{item.shortLink}' target="_blank">{item.shortLink}</a></div>
					<div class="">{item.url}</div>
					<div class="d-flex justify-content-between mb-1 mt-3">
						<div class="card-text">
							Visits: {item.visitsAmount}
						</div>
						<div class="card-text">
							Valid To: {date(item.validTo)}
						</div>
					</div>
					<div class="progress">
						<div
							class="progress-bar bg-warning"
							role="progressbar"
							style="width: {item.progress}%;">
						</div>
					</div>
				</div>
			</div>
		{/each}
	</div>
</div>
