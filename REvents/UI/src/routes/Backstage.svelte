<script lang="ts">
    import { onMount } from 'svelte';
    import { day, date, time } from '../tools/formatting'

    export let data: any = null;
    export let events: [] = null;
    onMount(async () => {
        const response = await fetch(`/api/events/backstage`);
        data = await response.json();
        events = data.events;
    });

</script>

<h1>Backstage</h1>
{#if data != null}
<div class="row">
    {#each events as p }
    <div class="col-12 col-xs-9">
        <div class="card mb-1">
            <div class="card-header d-flex justify-content-between">
                <div>{ date(p.date) }</div>
                <div>{ day(p.date) }</div>
            </div>
            <div class="card-body pb-0">
                {#each p.events as e}
                <div class="d-flex flex-wrap justify-content-between">
                    <div>
                        <span>{ time(e.date) }</span>
                        { e.title }
                    </div>
                    <div>{ e.details }</div>
                </div>
                <div class="d-flex flex-wrap">
                    {#each e.types as t}
                    <span class="badge rounded-pill bg-secondary text-light mr-1 mt-1">{t}</span>
                    {/each}
                </div>
                <hr class="mb-0" />
                {/each}
            </div>
        </div>
    </div>
    {/each}
</div>
{/if}