<script lang="ts">
	import { onMount } from "svelte";
	import { get } from "../../tools/utils";
	import { date } from "../../tools/formatting";

	let links: ShortLinkInfo[] = [];
	onMount(async () => {
		links = (await get<ShortLinkInfo[]>(`/api/ShortLinks`)) ?? [];
		const max = Math.max(...links.map((l) => l.visitsAmount));
		links.forEach((l) => {
			l.progress = 100 * (l.visitsAmount / max);
			l.shortLink = `${location.origin}/sl/${l.code}`;
		});
	});

	interface ShortLinkInfo {
		id: string;
		code: string;
		title: string;
		validTo: Date;
		url: string;
		visitsAmount: number;
		progress?: number;
		shortLink?: string;
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
						<button class="btn btn-secondary btn-sm d-flex gap-2">
							<box-icon name="share-alt" color="#ffffff"></box-icon>
							<span class="">SHARE</span>
						</button>
					</div>
				</div>
				<div class="card-body">
					<div class="">{item.shortLink}</div>
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
