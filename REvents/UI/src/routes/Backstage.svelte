<script>
    import { onMount } from 'svelte';
    export let posts;
    onMount(async () => {
        const response = await fetch(`/api/events/backstage`);
        posts = await response.json();
    });
</script>

<h1>Backstage</h1>