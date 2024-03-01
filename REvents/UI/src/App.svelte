<script lang="ts">
    import { Router, Link, Route } from "svelte-routing";
    import Home from "./routes/Home.svelte";
    import Backstage from "./routes/Backstage.svelte";
    import Impressum from "./routes/Impressum.svelte";

    export let url = "";
    export let y = new Date().getFullYear();
</script>


<Router {url}>
    <div class="container">
        <h1 class="text-primary"><Link class="text-primary" to="/">Мюнхен Афиша</Link></h1>
    </div>
    <hr />
    <!--  <nav>
        <Link to="/">Home</Link>
        <Link to="/backstage">backstage</Link>
      </nav>-->
    <div class="container mb-auto">
        <Route path="/backstage">
            <Backstage />
        </Route>
        <Route path="/impressum">
            <Impressum />
        </Route>
        <Route path="/">
            <Home />
        </Route>
    </div>
    <footer class="bg-secondary d-flex justify-content-around p-4 mt-4">
        <div class="text-primary">© { y } Мюнхен Афиша</div>
        <Link class="text-primary" to="/impressum">Impressum</Link>
    </footer>
</Router>