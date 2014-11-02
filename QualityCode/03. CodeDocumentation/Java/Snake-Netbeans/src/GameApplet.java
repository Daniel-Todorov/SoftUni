
import java.applet.Applet;
import java.awt.Dimension;
import java.awt.Graphics;

/**
 * A class that allows the game to be run as applet.
 * @author Anonimous
 */
@SuppressWarnings("serial")
public class GameApplet extends Applet {

    /**
     * represents the instance of the game.
     */
    private Game game;
    /**
     * Represents the key listener.
     */
    GameKeyListener keyListener;

    /**
     * Initialize the game as an applet.
     */
    @Override
    public void init() {
        game = new Game();
        game.setPreferredSize(new Dimension(800, 650));
        game.setVisible(true);
        game.setFocusable(true);
        this.add(game);
        this.setVisible(true);
        this.setSize(new Dimension(800, 650));
        keyListener = new GameKeyListener(game);
    }

    /**
     * Sets size of the game screen.
     * @param graphics The default graphic adapter.
     */
    @Override
    public void paint(Graphics graphics) {
        this.setSize(new Dimension(800, 650));
    }

}
