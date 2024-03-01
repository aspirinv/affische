<script>
    import { onMount } from 'svelte';
    export let posts = [];
    onMount(async () => {
        const response = await fetch(`/api/events/backstage`);
        posts = await response.json();
    });
</script>

<h1>Backstage</h1>
<div class="row">
    {#each posts as p}
    <div class="col-md-4 col-xl-2 col-lg-3 col-sm-12">
        <div class="card mb-1">
            <div class="card-header">{p.title}</div>
            <div class="card-body">
                <div>{p.details}</div>
                <div>{p.date}</div>
                <div class="d-flex flex-wrap">
                    {#each p.types as t}
                    <span class="badge rounded-pill bg-secondary text-light mr-1 mt-1">{t}</span>
                    {/each}
                </div>
            </div>
        </div>
    </div>
    {/each}
</div>