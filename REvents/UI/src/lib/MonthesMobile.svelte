<script lang="ts">
    import { onMount, createEventDispatcher } from 'svelte';
    import { MonthesScrollBridge } from '../tools/monthes'

    const monthesBridge = new MonthesScrollBridge(createEventDispatcher());

    const pointerScroll = (main, highlight) => {

        main.addEventListener("scroll", e => {
            highlight.scrollTop = Math.max(0, main.scrollTop);
            monthesBridge.scroll(main.scrollTop);
        })

        highlight.addEventListener("scroll", e => {
            const top = Math.max(0, highlight.scrollTop);
            main.scrollTop = top;
            monthesBridge.scroll(top);
        })
    };

    onMount(() => {
        pointerScroll(
            document.getElementById('mnths-parent'),
            document.getElementById('mnths-parent-highlight')
        );
    });

</script>
<div style="position:relative;">
    <div style="overflow:auto; height:240px;" id="mnths-parent" class="no-scroll">
        <div id="mnths-child" class="user-select-none" style="cursor: pointer">
            <div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>
            {#each monthesBridge.mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
    <div style="overflow: auto; height: 80px; position: absolute; top: 80px;" class="no-scroll" id="mnths-parent-highlight">
        <div id="mnths-child-highlight" class="user-select-none" style="cursor: pointer;">
            <!--<div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>-->
            {#each monthesBridge.mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center bg-primary text-white"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
</div>